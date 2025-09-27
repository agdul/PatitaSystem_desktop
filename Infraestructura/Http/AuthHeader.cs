// Archivo: Infraestructura/Http/AuthHeader.cs
using PatitaSystem.Infraestructura.Seguridad;
using System.Net.Http.Headers;

namespace PatitaSystem.Infraestructura.Http;

/// <summary>
/// Inyecta encabezados de autenticación antes de enviar la request:
/// - Authorization: Bearer &lt;token&gt;
/// - info: &lt;token&gt;  (compat con APIs que lo esperan en este header)
/// </summary>
public sealed class AuthHeader : DelegatingHandler
{
    private readonly ITokenStore _tokenStore;

    public AuthHeader(ITokenStore tokenStore)
    {
        _tokenStore = tokenStore ?? throw new ArgumentNullException(nameof(tokenStore));
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var token = await _tokenStore.LoadAsync(cancellationToken).ConfigureAwait(false);

        if (!string.IsNullOrWhiteSpace(token))
        {
            if (!request.Headers.Contains("Authorization"))
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

            if (!request.Headers.Contains("info"))
                request.Headers.TryAddWithoutValidation("info", token);
        }

        if (!request.Headers.Accept.Any(h => h.MediaType == "application/json"))
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
    }
}
