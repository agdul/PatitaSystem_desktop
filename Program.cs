using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PatitaSystem.Infraestructura.Http;

using PatitaSystem.Infraestructura.Seguridad;
using PatitaSystem.Presentacion.App;
using PatitaSystem.Servicios;
using System.Net.Http.Headers;

namespace PatitaSystem;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize(); // Siempre al inicio de Main


        // ----------------------------------------
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
        Application.ThreadException += (s, ex) =>
        {
            MessageBox.Show(ex.Exception.ToString(), "ThreadException",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        };
        AppDomain.CurrentDomain.UnhandledException += (s, ex) =>
        {
            MessageBox.Show(ex.ExceptionObject?.ToString() ?? "Error desconocido",
                "UnhandledException", MessageBoxButtons.OK, MessageBoxIcon.Error);
        };
        // ----------------------------------------


        // Configuramos el contenedor de servicios
        var config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

        var services = new ServiceCollection();
        services.AddSingleton<IConfiguration>(config);

        // ===== Infra =====
        services.AddSingleton<ITokenStore, TokenStore>();
        services.AddTransient<AuthHeaderHandler>();

        // ===== HttpClientes =====
        services.AddHttpClient("PatitaApiPublic", client =>
        {
            client.BaseAddress = new Uri(config["Api:BaseUrl"] ?? "http://localhost:3001/api/v1/");
            client.Timeout = TimeSpan.FromSeconds(15);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        });
        services.AddHttpClient("PatitaApiAuth", client =>
        {
            client.BaseAddress = new Uri(config["Api:BaseUrl"] ?? "http://localhost:3001/api/v1/");
            client.Timeout = TimeSpan.FromSeconds(15);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        })
        .AddHttpMessageHandler<AuthHeaderHandler>();

        // ===== App (servicios) =====
        services.AddSingleton<IAuthService, AuthService>();

        // ===== UI (forms) =====
        services.AddTransient<Login_Form>();
        services.AddTransient<Dashboard_Form>();


        // Corremos la app con nuestro ApplicationContext
        var provider = services.BuildServiceProvider();
        Application.Run(new ContextoPatita((ServiceProvider)provider));

    }
}
