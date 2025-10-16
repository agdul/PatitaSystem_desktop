// Archivo: Dominio/Usuarios/UsuarioUpdateRequest.cs
using System.Text.Json.Serialization;

namespace PatitaSystem.Dominio.Usuarios
{
    /// <summary>
    /// Body para actualizar usuario (PUT /api/v1/usuario/:id).
    /// En tu API se envían todos los campos (modificados o no).
    /// </summary>
    public sealed class UsuarioUpdateRequest
    {
        [JsonPropertyName("id_direccion")]
        public int IdDireccion { get; set; }

        [JsonPropertyName("id_genero")]
        public int IdGenero { get; set; }

        [JsonPropertyName("dni_usuario")]
        public string Dni { get; set; } = "";

        [JsonPropertyName("apellido_usuario")]
        public string Apellido { get; set; } = "";

        [JsonPropertyName("nombre_usuario")]
        public string Nombre { get; set; } = "";

        [JsonPropertyName("usuario")]
        public string NombreUsuario { get; set; } = "";

        [JsonPropertyName("email_usuario")]
        public string Email { get; set; } = "";

        /// <summary>Formato esperado: "yyyy-MM-dd".</summary>
        [JsonPropertyName("fec_nac")]
        public string FechaNacimiento { get; set; } = "";

        [JsonPropertyName("celular_usuario")]
        public string Celular { get; set; } = "";
    }
}
