using System.Text.Json.Serialization;

namespace PatitaSystem.Dominio.Auth;

/// <summary>
/// Payload de login que tu API espera: { "usuario", "password" }.
/// </summary>
public sealed class LoginRequest
{
    [JsonPropertyName("usuario")]
    public string Usuario { get; set; } = string.Empty;

    [JsonPropertyName("password")]
    public string Password { get; set; } = string.Empty;
}
