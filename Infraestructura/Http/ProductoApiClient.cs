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
            // 👇 agrega el conversor una sola vez
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
    }
}
