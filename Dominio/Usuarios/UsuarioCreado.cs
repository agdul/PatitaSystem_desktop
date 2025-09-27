// Archivo: Dominio/Usuarios/UsuarioCreadoDto.cs
using System.Text.Json.Serialization;

namespace PatitaSystem.Dominio.Usuarios
{
    /// <summary>
    /// Respuesta de la API al crear/actualizar usuario.
    /// </summary>
    public sealed class UsuarioCreadoDto
    {
        [JsonPropertyName("id_usuario")]
        public int IdUsuario { get; set; }

        [JsonPropertyName("usuario")]
        public string? NombreUsuario { get; set; }

        [JsonPropertyName("email_usuario")]
        public string? Email { get; set; }

        [JsonPropertyName("celular_usuario")]
        public string? Celular { get; set; }

        [JsonPropertyName("estado_usuario")]
        public bool Estado { get; set; }

        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        [JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }
    }
}
