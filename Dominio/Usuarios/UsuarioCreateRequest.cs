// Archivo: Dominio/Usuarios/UsuarioCreateRequest.cs
using System.Text.Json.Serialization;

namespace PatitaSystem.Dominio.Usuarios
{
    /// <summary>
    /// Body para crear usuario (POST /api/v1/usuario/).
    /// Coincide con tu RAW de Postman.
    /// </summary>
    public sealed class UsuarioCreateRequest
    {
        [JsonPropertyName("id_direccion")]
        public int IdDireccion { get; set; }

        [JsonPropertyName("id_rol")]
        public int IdRol { get; set; }

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

        [JsonPropertyName("password")]
        public string Password { get; set; } = "";

        [JsonPropertyName("email_usuario")]
        public string Email { get; set; } = "";

        [JsonPropertyName("estado_usuario")]
        public bool Estado { get; set; }

        /// <summary>Formato esperado: "yyyy-MM-dd".</summary>
        [JsonPropertyName("fec_nac")]
        public string FechaNacimiento { get; set; } = "";

        [JsonPropertyName("celular_usuario")]
        public string Celular { get; set; } = "";
    }
}
