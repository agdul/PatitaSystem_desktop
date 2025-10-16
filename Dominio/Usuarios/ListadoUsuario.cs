// Archivo: Dominio/Usuarios/UsuarioListadoDto.cs
using System.Text.Json.Serialization;

namespace PatitaSystem.Dominio.Usuarios
{
    /// <summary>
    /// DTO para listar usuarios en el Admin.
    /// Mapea los campos que realmente mostramos en el ListView.
    /// </summary>
    public sealed class UsuarioListadoDto
    {
        [JsonPropertyName("id_usuario")]
        public int IdUsuario { get; set; }

        [JsonPropertyName("usuario")]
        public string? Usuario { get; set; }

        [JsonPropertyName("password")]
        public string? Password { get; set; }

        [JsonPropertyName("email_usuario")]
        public string? Email { get; set; }

        [JsonPropertyName("celular_usuario")]
        public string? Celular { get; set; }

        // Extra: si luego querés nombre/apellido en columnas
        [JsonPropertyName("nombre_usuario")]
        public string? Nombre { get; set; }

        [JsonPropertyName("apellido_usuario")]
        public string? Apellido { get; set; }

        [JsonPropertyName("estado_usuario")]
        public bool EstadoUsuario { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }


        // Ejemplo de anidados por si se necesitan a futuro (rol/dirección)
        // [JsonPropertyName("rol")]
        // public RolDto? Rol { get; set; }
    }

    //public sealed class UsuarioCreateRequest
    //{
    //    [JsonPropertyName("id_direccion")]
    //    public int IdDireccion { get; set; }      // TODO: por ahora usamos un valor fijo hasta que integres el alta de dirección
    //    [JsonPropertyName("id_rol")]
    //    public int IdRol { get; set; }
    //    [JsonPropertyName("id_genero")]
    //    public int IdGenero { get; set; }         // TODO: por ahora fijo (1) hasta que agregues selector de género
    //    [JsonPropertyName("dni_usuario")]
    //    public string DniUsuario { get; set; } = "";
    //    [JsonPropertyName("apellido_usuario")]
    //    public string ApellidoUsuario { get; set; } = "";
    //    [JsonPropertyName("nombre_usuario")]
    //    public string NombreUsuario { get; set; } = "";
    //    [JsonPropertyName("usuario")]
    //    public string Usuario { get; set; } = "";
    //    [JsonPropertyName("password")]
    //    public string Password { get; set; } = "";
    //    [JsonPropertyName("email_usuario")]
    //    public string EmailUsuario { get; set; } = "";
    //    [JsonPropertyName("estado_usuario")]
    //    public bool EstadoUsuario { get; set; }
    //    [JsonPropertyName("fec_nac")]
    //    public string FechaNacimiento { get; set; } = "";  // "yyyy-MM-dd"
    //    [JsonPropertyName("celular_usuario")]
    //    public string CelularUsuario { get; set; } = "";
    //}

}
