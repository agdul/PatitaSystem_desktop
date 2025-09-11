using System.Text.Json.Serialization;

namespace PatitaSystem.Dominio.Auth;

/// <summary>
/// Representa la respuesta de /auth/login
/// </summary>
public sealed class LoginResponse
{
    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;

    // Importante: API manda "user", no "usuario"
    [JsonPropertyName("user")]
    public UsuarioDto User { get; set; } = default!;
}

/// <summary>
/// Representa los datos del usuario devueltos en la respuesta de login.
/// </summary>
public sealed class UsuarioDto
{
    [JsonPropertyName("id_usuario")]
    public int IdUsuario { get; set; }

    [JsonPropertyName("id_direccion")]
    public int IdDireccion { get; set; }

    [JsonPropertyName("id_rol")]
    public int IdRol { get; set; }

    [JsonPropertyName("id_genero")]
    public int IdGenero { get; set; }

    [JsonPropertyName("dni_usuario")]
    public string DniUsuario { get; set; } = string.Empty;

    [JsonPropertyName("apellido_usuario")]
    public string ApellidoUsuario { get; set; } = string.Empty;

    [JsonPropertyName("nombre_usuario")]
    public string NombreUsuario { get; set; } = string.Empty;

    [JsonPropertyName("usuario")]
    public string Usuario { get; set; } = string.Empty;

    [JsonPropertyName("password")]
    public string Password { get; set; } = string.Empty;

    [JsonPropertyName("email_usuario")]
    public string EmailUsuario { get; set; } = string.Empty;

    [JsonPropertyName("estado_usuario")]
    public bool EstadoUsuario { get; set; }

    [JsonPropertyName("fec_nac")]
    public DateTime FechaNacimiento { get; set; }

    [JsonPropertyName("celular_usuario")]
    public string CelularUsuario { get; set; } = string.Empty;

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }

    // El token viene dentro del objeto user 👀
    [JsonPropertyName("token")]
    public string Token { get; set; } = string.Empty;
}
