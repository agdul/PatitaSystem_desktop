using PatitaSystem.Dominio.Producto;
using PatitaSystem.Infraestructura.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PatitaSystem.Infraestructura.Http
{
    public sealed class ProductoApiClient
    {
        private readonly HttpClient _http;
        // Opciones robustas de JSON (idénticas a UsuarioApiClient)
        private static readonly JsonSerializerOptions _json = new()
        {
            PropertyNameCaseInsensitive = true,
            ReadCommentHandling = JsonCommentHandling.Skip,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            NumberHandling = JsonNumberHandling.AllowReadingFromString
        };

        static ProductoApiClient()
        {
            // agrega el conversor una sola vez
            _json.Converters.Add(new FlexibleBoolConverter());
        }


        public ProductoApiClient(HttpClient http)
        {
            _http = http ?? throw new ArgumentNullException(nameof(http));
        }


        /// <summary>
        /// GET /producto/ — Lista todos los productos.
        /// </summary>
        public async Task<IReadOnlyList<ProductoResponse>> GetProductosAsync(CancellationToken ct = default)
        {
            using var resp = await _http.GetAsync("producto/", ct).ConfigureAwait(false);
            var text = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);
            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException($"API Producto devolvió {(int)resp.StatusCode} {resp.ReasonPhrase}. Cuerpo: {text}");
            var data = JsonSerializer.Deserialize<List<ProductoResponse>>(text, _json);
            return data ?? new List<ProductoResponse>();
        }


        /// <summary>
        /// Helper que retorna List&lt;T&gt; directo.
        /// </summary>
        public async Task<List<ProductoResponse>> ListarAsync(CancellationToken ct = default)
            => (await GetProductosAsync(ct).ConfigureAwait(false)).ToList();


        /// <summary>
        /// GET /producto/{id} — Obtiene un producto por ID.
        /// </summary>
        public async Task<ProductoResponse?> GetPorIdAsync(int id, CancellationToken ct = default)
        {
            using var resp = await _http.GetAsync($"producto/{id}", ct).ConfigureAwait(false);
            var text = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);
            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException($"API Producto devolvió {(int)resp.StatusCode} {resp.ReasonPhrase}. Cuerpo: {text}");
            var data = JsonSerializer.Deserialize<ProductoResponse>(text, _json);
            return data;
        }


        /// <summary>
        /// POST /producto/ — Crea un nuevo producto.
        /// </summary>
        public async Task<ProductoResponse?> CrearAsync(ProductoRequest nuevo, CancellationToken ct = default)
        {
            var content = new StringContent(JsonSerializer.Serialize(nuevo, _json), Encoding.UTF8, "application/json");
            using var resp = await _http.PostAsync("producto/", content, ct).ConfigureAwait(false);
            var text = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);
            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException($"API Producto devolvió {(int)resp.StatusCode} {resp.ReasonPhrase}. Cuerpo: {text}");
            var data = JsonSerializer.Deserialize<ProductoResponse>(text, _json);
            return data;
        }

        /// <summary>
        /// PUT /producto/{id} — Actualiza un producto existente.
        /// </summary>
        public async Task<ProductoResponse?> ActualizarAsync(int id, ProductoRequest actualizado, CancellationToken ct = default)
        {
            var content = new StringContent(JsonSerializer.Serialize(actualizado, _json), Encoding.UTF8, "application/json");
            using var resp = await _http.PutAsync($"producto/{id}", content, ct).ConfigureAwait(false);
            var text = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);
            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException($"API Producto devolvió {(int)resp.StatusCode} {resp.ReasonPhrase}. Cuerpo: {text}");
            var data = JsonSerializer.Deserialize<ProductoResponse>(text, _json);
            return data;
        }

        /// <summary>
        /// DELETE /producto/{id} — Elimina un producto por ID.
        /// </summary>
        public async Task<bool> EliminarAsync(int id, CancellationToken ct = default)
        {
            using var resp = await _http.DeleteAsync($"producto/{id}", ct).ConfigureAwait(false);
            if (resp.IsSuccessStatusCode)
                return true;
            var text = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);
            throw new HttpRequestException($"API Producto devolvió {(int)resp.StatusCode} {resp.ReasonPhrase}. Cuerpo: {text}");
        }




        /// <summary>
        /// Autocomplete contra /producto/search usando los parámetros:
        ///   q = texto, limit = tope, offset = desplazamiento (paginación)
        ///
        /// El método es tolerante a:
        ///  - Respuesta como array plano: [ {idProducto|id_producto|id, nombre|nombre_producto|name}, ... ]
        ///  - Respuesta paginada como objeto: { items|data|rows: [ ... ], total?, ... }
        ///
        /// Buenas prácticas:
        /// - No dispara si q &lt; 2 chars.
        /// - Corta con CancellationToken si el usuario sigue tipeando.
        /// - Acota limit a [1..50].
        /// </summary>
        public async Task<IReadOnlyList<ProductoSearchAutocomplete>> BuscarAutocompleteAsync(
            string q,
            int limit = 10,
            int offset = 0,
            CancellationToken ct = default)
        {
            if (string.IsNullOrWhiteSpace(q) || q.Trim().Length < 2)
                throw new ArgumentException("El texto de búsqueda (q) debe tener al menos 2 caracteres.", nameof(q));

            if (limit < 1) limit = 1;
            if (limit > 50) limit = 50;
            if (offset < 0) offset = 0;

            // Construir URL: /producto/search?q=...&limit=...&offset=...
            var baseUri = new Uri(_http.BaseAddress!, "producto/search");
            var uri = new Uri($"{baseUri}?q={Uri.EscapeDataString(q.Trim())}&limit={limit}&offset={offset}");

            using var req = new HttpRequestMessage(HttpMethod.Get, uri);
            using var resp = await _http.SendAsync(req, HttpCompletionOption.ResponseHeadersRead, ct)
                                        .ConfigureAwait(false);

            if (!resp.IsSuccessStatusCode)
            {
                var payload = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);
                throw new HttpRequestException(
                    $"Error {(int)resp.StatusCode} al buscar productos (search). Detalle: {payload}",
                    null,
                    resp.StatusCode);
            }

            await using var stream = await resp.Content.ReadAsStreamAsync(ct).ConfigureAwait(false);
            using var doc = await JsonDocument.ParseAsync(stream, cancellationToken: ct).ConfigureAwait(false);

            var resultados = new List<ProductoSearchAutocomplete>();

            if (doc.RootElement.ValueKind == JsonValueKind.Array)
            {
                // Caso 1: array directo
                foreach (var elem in doc.RootElement.EnumerateArray())
                    if (TryMapProducto(elem, out var item))
                        resultados.Add(item);
            }
            else if (doc.RootElement.ValueKind == JsonValueKind.Object)
            {
                // Caso 2: objeto paginado → buscar colección en items | data | rows
                if (TryGetArray(doc.RootElement, out var arr))
                {
                    foreach (var elem in arr.EnumerateArray())
                        if (TryMapProducto(elem, out var item))
                            resultados.Add(item);
                }
            }

            return resultados;
        }
        // ====================== FIN NUEVO ===========================

        // ---------- Helpers privados para mapear respuestas ----------

        private static bool TryGetArray(JsonElement root, out JsonElement arr)
        {
            // Acepta varias convenciones: items, data, rows
            if (root.TryGetProperty("items", out arr) && arr.ValueKind == JsonValueKind.Array)
                return true;
            if (root.TryGetProperty("data", out arr) && arr.ValueKind == JsonValueKind.Array)
                return true;
            if (root.TryGetProperty("rows", out arr) && arr.ValueKind == JsonValueKind.Array)
                return true;

            arr = default;
            return false;
        }

        private static bool TryMapProducto(JsonElement json, out ProductoSearchAutocomplete item)
        {
            // Id: idProducto | id_producto | id
            int? id = null;
            if (json.TryGetProperty("idProducto", out var idProd) && idProd.TryGetInt32(out var v1)) id = v1;
            else if (json.TryGetProperty("id_producto", out var idProd2) && idProd2.TryGetInt32(out var v2)) id = v2;
            else if (json.TryGetProperty("id", out var id3) && id3.TryGetInt32(out var v3)) id = v3;

            // Nombre: nombre | nombre_producto | name
            string? nombre = null;
            if (json.TryGetProperty("nombre", out var n1) && n1.ValueKind == JsonValueKind.String) nombre = n1.GetString();
            else if (json.TryGetProperty("nombre_producto", out var n2) && n2.ValueKind == JsonValueKind.String) nombre = n2.GetString();
            else if (json.TryGetProperty("name", out var n3) && n3.ValueKind == JsonValueKind.String) nombre = n3.GetString();

            if (id is int idOk && !string.IsNullOrWhiteSpace(nombre))
            {
                item = new ProductoSearchAutocomplete
                {
                    IdProducto = idOk,
                    NombreProducto = nombre!
                };
                return true;
            }

            item = default!;
            return false;
        }
    }
}



    

