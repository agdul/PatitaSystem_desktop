// Archivo: Infraestructura/Http/PresentacionApiClient.cs
using PatitaSystem.Dominio.Presentacion;
using PatitaSystem.Infraestructura.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PatitaSystem.Infraestructura.Http
{
    /// <summary>
    /// Cliente HTTP para Presentaciones.
    /// BaseAddress esperado: http://localhost:3001/api/v1/
    /// </summary>
    public class PresentacionApiClient
    {
        private readonly HttpClient _http;

        // Opciones robustas de JSON
        private static readonly JsonSerializerOptions _json = new()
        {
            PropertyNameCaseInsensitive = true,
            ReadCommentHandling = JsonCommentHandling.Skip,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            NumberHandling = JsonNumberHandling.AllowReadingFromString
        };

        static PresentacionApiClient()
        {
            _json.Converters.Add(new FlexibleBoolConverter());
        }

        public PresentacionApiClient(HttpClient httpClient)
        {
            _http = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        // ============================================================
        // GET /producto/presentacion/ - Lista todas las presentaciones
        // (si tu API lo soporta)
        // ============================================================
        public async Task<IReadOnlyList<PresentacionResponse>> GetPresentacionesAsync(
            CancellationToken ct = default)
        {
            using var response = await _http.GetAsync("producto/presentacion/", ct).ConfigureAwait(false);
            var text = await response.Content.ReadAsStringAsync(ct).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException($"Error al obtener presentaciones: {response.StatusCode} - {text}");

            var presentaciones = JsonSerializer.Deserialize<IReadOnlyList<PresentacionResponse>>(text, _json);
            return presentaciones ?? new List<PresentacionResponse>();
        }

        /// <summary>
        /// Helper que retorna la lista como List&lt;T&gt;.
        /// </summary>
        public async Task<List<PresentacionResponse>> ListarAsync(CancellationToken ct = default)
        {
            var presentaciones = await GetPresentacionesAsync(ct).ConfigureAwait(false);
            return presentaciones.ToList();
        }

        // ============================================================
        // (NUEVO) GET /producto/{idProducto}/presentacion
        // Lista presentaciones de un producto específico.
        // ============================================================
        /// <summary>
        /// Devuelve las presentaciones pertenecientes a un producto.
        /// </summary>
        public async Task<IReadOnlyList<PresentacionResponse>> ListarPorProductoAsync(
            int idProducto,
            CancellationToken ct = default)
        {
            if (idProducto <= 0)
                throw new ArgumentOutOfRangeException(nameof(idProducto), "El id de producto debe ser > 0.");

            var url = $"producto/{idProducto}/presentacion";
            using var response = await _http.GetAsync(url, ct).ConfigureAwait(false);
            var text = await response.Content.ReadAsStringAsync(ct).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException($"Error al listar presentaciones del producto {idProducto}: {response.StatusCode} - {text}");

            var items = JsonSerializer.Deserialize<IReadOnlyList<PresentacionResponse>>(text, _json);
            return items ?? new List<PresentacionResponse>();
        }

        // ============================================================
        //  POST /producto/{idProducto}/presentacion
        // Crea una nueva presentación asociada al producto (id en URL).
        // ============================================================
        /// <summary>
        /// Crea una presentación bajo un producto dado.
        /// Endpoint: POST /producto/{idProducto}/presentacion
        /// </summary>
        /// <param name="idProducto">Id del producto (va en la ruta).</param>
        /// <param name="request">Datos de la presentación a crear.</param>
        /// <param name="ct">Token de cancelación.</param>
        /// <returns>La presentación creada (según responda tu API).</returns>
        /// <exception cref="HttpRequestException">Si la API responde con código no exitoso.</exception>
        /// <exception cref="InvalidOperationException">Si no se puede deserializar la respuesta.</exception>
        public async Task<PresentacionResponse?> CrearAsync(
            int idProducto,
            PresentacionRequest request,
            CancellationToken ct = default)
        {
            if (idProducto <= 0)
                throw new ArgumentOutOfRangeException(nameof(idProducto), "El id de producto debe ser > 0.");
            if (request is null)
                throw new ArgumentNullException(nameof(request));

            // Construimos la URL correcta con el id en la ruta
            var url = $"producto/{idProducto}/presentacion";

            // Serializamos el body (IMPORTANTE: request es el DTO de entrada, no la Response)
            var json = JsonSerializer.Serialize(request, _json);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");

            using var resp = await _http.PostAsync(url, content, ct).ConfigureAwait(false);
            var text = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);

            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException(
                    $"Error {(int)resp.StatusCode} al crear presentación (productoId={idProducto}). Detalle: {text}",
                    null, resp.StatusCode);

            try
            {
                return JsonSerializer.Deserialize<PresentacionResponse>(text, _json);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(
                    $"No se pudo deserializar la respuesta de creación de presentación. Payload: {text}", ex);
            }
        }

        //// ============================================================
        //// (OBSOLETO) Método viejo para evitar confusiones
        //// ============================================================
        //[Obsolete("Usar CrearAsync(int idProducto, PresentacionRequest, CancellationToken).")]
        //public Task<PresentacionResponse?> CrearPresentacionAsync(
        //    PresentacionResponse nuevaPresentacion,
        //    CancellationToken ct = default)
        //{
        //    // Evita usos antiguos: el id debe ir en la URL y el body debe ser el Request, no la Response
        //    throw new NotSupportedException(
        //        "Este proyecto usa POST /producto/{id}/presentacion con body PresentacionRequest. " +
        //        "Llamá a CrearAsync(idProducto, request, ct).");
        //}
    }
}
