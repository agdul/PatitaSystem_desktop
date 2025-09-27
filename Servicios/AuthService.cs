using Microsoft.Extensions.Configuration;
using PatitaSystem.Dominio.Auth;
using PatitaSystem.Infraestructura.Seguridad;
using PatitaSystem.Utilidades;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

namespace PatitaSystem.Servicios;

/// <summary>
/// Implementación que usa IHttpClientFactory y mapea errores de forma consistente.
/// </summary>
public sealed class AuthService : IAuthService // Clase sellada (no se puede heredar), que implementa IAuthService
{
    // campos privados de la clase AuthService
    private readonly IHttpClientFactory _httpFactory;
    private readonly IConfiguration _config;
    private readonly ITokenStore _tokenStore;

    public AuthService(IHttpClientFactory httpFactory, IConfiguration config, ITokenStore tokenStore) //Constructor 
    {
        _httpFactory = httpFactory;
        _config = config;
        _tokenStore = tokenStore;
    }

    /// <inheritdoc />
    /// 
    //Task<Result<LoginResponse>>: Devuelve una tarea que, al completarse, contiene un objeto Result<LoginResponse>.
    public async Task<Result<LoginResponse>> LoginAsync(LoginRequest req, CancellationToken ct = default)
    {
        try
        {
            using var client = _httpFactory.CreateClient("PatitaApiPublic"); // Usa la fábrica para crear un HttpClient configurado con el nombre "PatitaApiPublic".
            var path = _config["Auth:LoginPath"] ?? "auth/login"; // Ruta x configurada en appsettings.json o valor por defecto.

            // Envía una petición POST a la API, con los datos de login (req) en formato JSON y espera la respuesta.
            using var resp = await client.PostAsJsonAsync(path, req, ct);

            // Almacena el contenido de la respuesta de la API como texto.
            var raw = await resp.Content.ReadAsStringAsync(ct);

            if (!resp.IsSuccessStatusCode) // Si la respuesta no fue exitosa...
                return Result<LoginResponse>.Fail(MapError(resp.StatusCode, raw)); // Devuelve un resultado de error, usando el método MapError para obtener el mensaje.

            LoginResponse? payload; // Variable para almacenar los datos deserializados de la respuesta.
                                  
            try
            {
                payload = JsonSerializer.Deserialize<LoginResponse>(raw,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }); 
                // Deserializa el JSON recibido en un objeto LoginResponse, ignorando mayúsculas/minúsculas en los nombres de las propiedades.
            }
            catch (Exception ex)
            {
                return Result<LoginResponse>.Fail($"Respuesta no interpretable: {ex.Message}");
            }

            if (payload is null) return Result<LoginResponse>.Fail("Respuesta vacía.");
            if (payload.User is null) return Result<LoginResponse>.Fail("Falta 'user' en la respuesta.");
            if (string.IsNullOrWhiteSpace(payload.User.Token))
                return Result<LoginResponse>.Fail("Falta 'user.token'.");

            await _tokenStore.SaveAsync(payload.User.Token, ct);
            return Result<LoginResponse>.Ok(payload);
        }
        catch (OperationCanceledException)
        {
            return Result<LoginResponse>.Fail("Timeout.");
        }
        catch (HttpRequestException ex)
        {
            return Result<LoginResponse>.Fail($"Sin conexión a la API: {ex.Message}");
        }
        catch (Exception ex)
        {
            return Result<LoginResponse>.Fail($"Error inesperado en Login: {ex.Message}");
        }
    }


    /// <inheritdoc />
    //public async Task<Result<bool>> RegisterAsync(RegisterRequest req, CancellationToken ct = default)
    //{
    //    try
    //    {
    //        using var client = _httpFactory.CreateClient("PatitaApi");
    //        var path = _config["Auth:RegisterPath"] ?? "auth/registro";

    //        using var resp = await client.PostAsJsonAsync(path, req, ct);
    //        if (resp.IsSuccessStatusCode)
    //            return Result<bool>.Ok(true);

    //        var text = await resp.Content.ReadAsStringAsync(ct);
    //        return Result<bool>.Fail(MapError(resp.StatusCode, text));
    //    }
    //    catch (OperationCanceledException)
    //    {
    //        return Result<bool>.Fail("Operación cancelada (timeout).");
    //    }
    //    catch (HttpRequestException ex)
    //    {
    //        return Result<bool>.Fail($"No se pudo conectar con la API: {ex.Message}");
    //    }
    //    catch (Exception ex)
    //    {
    //        return Result<bool>.Fail($"Error inesperado: {ex.Message}");
    //    }
    //}

    private static string MapError(HttpStatusCode code, string body)
    {
        return code switch
        {
            HttpStatusCode.BadRequest => "Solicitud inválida. " + ExtractMessage(body),
            HttpStatusCode.Unauthorized => "Credenciales inválidas.",
            HttpStatusCode.Forbidden => "Acceso denegado.",
            _ => $"Error {(int)code}. {ExtractMessage(body)}"
        };
    }

    private static string ExtractMessage(string body)
    {
        try
        {
            using var doc = JsonDocument.Parse(body);
            if (doc.RootElement.TryGetProperty("message", out var m)) return m.GetString() ?? "";
            if (doc.RootElement.TryGetProperty("error", out var e)) return e.GetString() ?? "";
        }
        catch { /* cuerpo no JSON */ }
        return body.Length > 200 ? body[..200] + "..." : body;
    }
}
