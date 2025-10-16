// Archivo: Infraestructura/Http/UsuarioApiClient.cs
using PatitaSystem.Dominio.Usuarios;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PatitaSystem.Infraestructura.Http
{
    /// <summary>
    /// Cliente HTTP para Usuarios.
    /// Requiere un HttpClient configurado con:
    ///  - BaseAddress = http://localhost:3001/api/v1/
    ///  - AuthHeader (Authorization + info)
    /// </summary>
    public sealed class UsuarioApiClient
    {
        private readonly HttpClient _http;

        // Opciones robustas para deserializar
        private static readonly JsonSerializerOptions _json = new()
        {
            PropertyNameCaseInsensitive = true,
            ReadCommentHandling = JsonCommentHandling.Skip,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            NumberHandling = JsonNumberHandling.AllowReadingFromString
        };

        public UsuarioApiClient(HttpClient http)
        {
            _http = http ?? throw new ArgumentNullException(nameof(http));
        }

        // ─────────────────────────────────────────────────────────────────────
        // LECTURA (LISTADO / DETALLE)
        // ─────────────────────────────────────────────────────────────────────

        /// <summary>
        /// GET /usuario/ — Devuelve una lista de usuarios (IReadOnlyList).
        /// </summary>
        public async Task<IReadOnlyList<UsuarioListadoDto>> GetUsuariosAsync(CancellationToken ct = default)
        {
            using var resp = await _http.GetAsync("usuario/", ct).ConfigureAwait(false);
            var text = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);

            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException($"API Usuarios devolvió {(int)resp.StatusCode} {resp.ReasonPhrase}. Cuerpo: {text}");

            var data = JsonSerializer.Deserialize<List<UsuarioListadoDto>>(text, _json);
            return data ?? new List<UsuarioListadoDto>();
        }

        /// <summary>
        /// Internamente llama a <see cref="GetUsuariosAsync"/> y devuelve List{T}.
        /// </summary>
        public async Task<List<UsuarioListadoDto>> ListarAsync(CancellationToken ct = default)
        {
            var list = await GetUsuariosAsync(ct).ConfigureAwait(false);
            return list.ToList();
        }

        /// <summary>
        /// (Opcional) GET /usuario/:id — Detalle de un usuario por Id.
        /// </summary>
        public async Task<UsuarioListadoDto?> GetUsuarioByIdAsync(int id, CancellationToken ct = default)
        {
            using var resp = await _http.GetAsync($"usuario/{id}", ct).ConfigureAwait(false);
            var text = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);

            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException($"API Usuarios devolvió {(int)resp.StatusCode} {resp.ReasonPhrase}. Cuerpo: {text}");

            var data = JsonSerializer.Deserialize<UsuarioListadoDto>(text, _json);
            return data;
        }

        /// <summary>GET /usuario/:id — devuelve detalle completo (rol, género, dirección).</summary>
        public async Task<UsuarioDetalleDto?> GetUsuarioDetalleByIdAsync(int id, CancellationToken ct = default)
        {
            using var resp = await _http.GetAsync($"usuario/{id}", ct).ConfigureAwait(false);
            var text = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);
            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException($"API Usuarios devolvió {(int)resp.StatusCode} {resp.ReasonPhrase}. Cuerpo: {text}");
            return JsonSerializer.Deserialize<UsuarioDetalleDto>(text, _json);
        }



        // ─────────────────────────────────────────────────────────────────────
        // ESCRITURA (CREAR / EDITAR)
        // ─────────────────────────────────────────────────────────────────────

        /// <summary>
        /// POST /usuario/ — Crea un usuario.
        /// </summary>
        public async Task<UsuarioCreadoDto> CreateUsuarioAsync(UsuarioCreateRequest req, CancellationToken ct = default)
        {
            var content = new StringContent(JsonSerializer.Serialize(req, _json), Encoding.UTF8, "application/json");

            using var resp = await _http.PostAsync("usuario/", content, ct).ConfigureAwait(false);
            var text = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);

            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException($"API Usuarios devolvió {(int)resp.StatusCode} {resp.ReasonPhrase}. Cuerpo: {text}");

            var data = JsonSerializer.Deserialize<UsuarioCreadoDto>(text, _json);
            if (data is null) throw new HttpRequestException("Respuesta vacía del servidor al crear usuario.");
            return data;
        }

        /// <summary>
        /// PUT /usuario/:id — Edita un usuario existente.
        /// </summary>
        public async Task<UsuarioCreadoDto> UpdateUsuarioAsync(int id, UsuarioUpdateRequest req, CancellationToken ct = default)
        {
            var content = new StringContent(JsonSerializer.Serialize(req, _json), Encoding.UTF8, "application/json");

            using var resp = await _http.PutAsync($"usuario/{id}", content, ct).ConfigureAwait(false);
            var text = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);

            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException($"API Usuarios devolvió {(int)resp.StatusCode} {resp.ReasonPhrase}. Cuerpo: {text}");

            var data = JsonSerializer.Deserialize<UsuarioCreadoDto>(text, _json);
            if (data is null) throw new HttpRequestException("Respuesta vacía del servidor al actualizar usuario.");
            return data;
        }
    }
}
