
using PatitaSystem.Infraestructura.Seguridad;
using System.Net.Http.Headers;

namespace PatitaSystem.Infraestructura.Http;

/// <summary>
/// DelegatingHandler que inyecta "Authorization: Bearer <token>" si hay token guardado.
/// Se ejecuta ANTES de que el HttpClient envíe la solicitud.
/// </summary>
public sealed class AuthHeader : DelegatingHandler
{
    private readonly ITokenStore _tokenStore;

    public AuthHeader(ITokenStore tokenStore)
    {
        _tokenStore = tokenStore;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        // Si ya existe el header (por algún caso especial), respetamos y no lo duplicamos.
        if (!request.Headers.Contains("Authorization"))
        {
            var token = await _tokenStore.LoadAsync(cancellationToken);
            if (!string.IsNullOrWhiteSpace(token))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }

        var response = await base.SendAsync(request, cancellationToken);

        // (Opcional) Si recibís 401, podrías limpiar token y/o redirigir a Login.
        // if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
        // {
        //     _tokenStore.Clear();
        //     // Notificar a la UI: "Sesión expirada" → volver a login
        // }

        return response;
    }
}
