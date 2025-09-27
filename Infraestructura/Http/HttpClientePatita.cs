// Archivo: Infraestructura/Http/HttpClientePatita.cs
using System.Net;
using System.Net.Http.Headers;
using PatitaSystem.Infraestructura.Seguridad;

namespace PatitaSystem.Infraestructura.Http
{
    /// <summary>
    /// HttpClient singleton para toda la app, con AuthHeader (Bearer + info).
    /// Inicializar una vez después del login: HttpClientePatita.Initialize(tokenStore, baseUrl).
    /// </summary>
    public static class HttpClientePatita
    {
        private static HttpClient? _instance;

        public static void Initialize(ITokenStore tokenStore, string baseUrl = "http://localhost:3001/")
        {
            if (tokenStore is null) throw new ArgumentNullException(nameof(tokenStore));

            var authHeader = new AuthHeader(tokenStore)
            {
                InnerHandler = new HttpClientHandler
                {
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                    UseCookies = false
                }
            };

            var client = new HttpClient(authHeader, disposeHandler: true)
            {
                BaseAddress = new Uri(baseUrl),
                Timeout = TimeSpan.FromSeconds(40)
            };

            client.DefaultRequestHeaders.UserAgent.ParseAdd("PatitaSystem-Desktop");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            _instance = client;
        }

        public static HttpClient Instance =>
            _instance ?? throw new InvalidOperationException(
                "HttpClientePatita no fue inicializado. Llamá a Initialize(tokenStore, baseUrl) después del login.");
    }
}
