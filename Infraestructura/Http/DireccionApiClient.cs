// Archivo: Infraestructura/Http/DireccionApiClient.cs
using PatitaSystem.Dominio.Direccion;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PatitaSystem.Infraestructura.Http
{
    /// <summary>
    /// Cliente HTTP para Direcciones.
    /// Requiere un HttpClient configurado con:
    ///  - BaseAddress = http://localhost:3001/api/v1/
    ///  - Handler de auth (si aplica) y Accept: application/json
    /// </summary>
    public sealed class DireccionApiClient
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

        public DireccionApiClient(HttpClient http)
        {
            _http = http ?? throw new ArgumentNullException(nameof(http));
        }

        /// <summary>
        /// GET /direccion/ — Lista todas las direcciones.
        /// </summary>
        public async Task<IReadOnlyList<DireccionResponse>> GetDireccionesAsync(CancellationToken ct = default)
        {
            using var resp = await _http.GetAsync("direccion/", ct).ConfigureAwait(false);
            var text = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);

            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException($"API Direccion devolvió {(int)resp.StatusCode} {resp.ReasonPhrase}. Cuerpo: {text}");

            var data = JsonSerializer.Deserialize<List<DireccionResponse>>(text, _json);
            return data ?? new List<DireccionResponse>();
        }

        /// <summary>
        /// Helper que retorna List&lt;T&gt; directo.
        /// </summary>
        public async Task<List<DireccionResponse>> ListarAsync(CancellationToken ct = default)
            => (await GetDireccionesAsync(ct).ConfigureAwait(false)).ToList();

        /// <summary>
        /// GET /direccion/{id} — Obtiene una dirección por ID.
        /// </summary>
        public async Task<DireccionResponse?> GetPorIdAsync(int id, CancellationToken ct = default)
        {
            using var resp = await _http.GetAsync($"direccion/{id}", ct).ConfigureAwait(false);
            var text = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);

            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException($"API Direccion devolvió {(int)resp.StatusCode} {resp.ReasonPhrase}. Cuerpo: {text}");

            return JsonSerializer.Deserialize<DireccionResponse>(text, _json);
        }

        /// <summary>
        /// POST /direccion/ — Crea una nueva dirección y devuelve el recurso creado.
        /// </summary>
        public async Task<DireccionResponse?> CrearAsync(DireccionRequest nuevaDireccion, CancellationToken ct = default)
        {
            var json = JsonSerializer.Serialize(nuevaDireccion, _json);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");

            using var resp = await _http.PostAsync("direccion/", content, ct).ConfigureAwait(false);
            var text = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);

            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException($"API Direccion devolvió {(int)resp.StatusCode} {resp.ReasonPhrase}. Cuerpo: {text}");

            return JsonSerializer.Deserialize<DireccionResponse>(text, _json);
        }

        /// <summary>
        /// PUT /direccion/{id} — Actualiza una dirección existente y devuelve el recurso actualizado.
        /// </summary>
        public async Task<DireccionResponse?> ActualizarAsync(int id, DireccionRequest direccionActualizada, CancellationToken ct = default)
        {
            var json = JsonSerializer.Serialize(direccionActualizada, _json);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");

            using var resp = await _http.PutAsync($"direccion/{id}", content, ct).ConfigureAwait(false);
            var text = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);

            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException($"API Direccion devolvió {(int)resp.StatusCode} {resp.ReasonPhrase}. Cuerpo: {text}");

            return JsonSerializer.Deserialize<DireccionResponse>(text, _json);
        }
    }
}
