// Archivo: Infraestructura/Http/LineaApiClient.cs
using System.Text.Json;
using System.Text.Json.Serialization;
using PatitaSystem.Dominio.Linea;

namespace PatitaSystem.Infraestructura.Http
{
    public sealed class LineaApiClient
    {
        private readonly HttpClient _http;

        private static readonly JsonSerializerOptions _json = new()
        {
            PropertyNameCaseInsensitive = true,
            ReadCommentHandling = JsonCommentHandling.Skip,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            NumberHandling = JsonNumberHandling.AllowReadingFromString
        };

        public LineaApiClient(HttpClient http)
        {
            _http = http ?? throw new ArgumentNullException(nameof(http));
        }
        
        /// <summary>GET /linea/ — Lista todas las líneas con sus categorías.</summary>
        public async Task<IReadOnlyList<LineaResponce>> ListarAsync(CancellationToken ct = default)
        {
            using var resp = await _http.GetAsync("linea/", ct).ConfigureAwait(false);
            var text = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);
            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException($"API Línea devolvió {(int)resp.StatusCode} {resp.ReasonPhrase}. Cuerpo: {text}");

            var data = JsonSerializer.Deserialize<List<LineaResponce>>(text, _json);
            return data ?? new List<LineaResponce>();
        }

        /// <summary>GET /linea/{id_linea}</summary>
        public async Task<LineaResponce?> GetPorIdAsync(int idLinea, CancellationToken ct = default)
        {
            using var resp = await _http.GetAsync($"linea/{idLinea}", ct).ConfigureAwait(false);
            var text = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);
            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException($"API Línea devolvió {(int)resp.StatusCode} {resp.ReasonPhrase}. Cuerpo: {text}");

            return JsonSerializer.Deserialize<LineaResponce>(text, _json);
        }
    }
}
