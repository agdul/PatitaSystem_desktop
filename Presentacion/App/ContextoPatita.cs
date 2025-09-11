using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;
using PatitaSystem.Infraestructura.Seguridad;

namespace PatitaSystem.Presentacion.App;

public sealed class ContextoPatita : ApplicationContext
{
    private readonly ServiceProvider _provider;

    public ContextoPatita(ServiceProvider provider)
    {
        _provider = provider;
        ShowLogin(); // método SIN async
    }

    private void ShowLogin()
    {
        var login = _provider.GetRequiredService<Login_Form>();

        // Lambda ASÍNCRONA (NO cambies esta firma con la app corriendo)
        login.LoginSucceeded += async (_, __) =>
        {
            var tokenStore = _provider.GetRequiredService<ITokenStore>();
            var token = await tokenStore.LoadAsync();
            if (string.IsNullOrWhiteSpace(token))
            {
                MessageBox.Show("No se encontró token tras el login.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            login.Hide();
            ShowDashboard();
            login.Close();
        };

        login.FormClosed += (_, __) =>
        {
            if (Application.OpenForms.Count == 0)
                ExitThread();
        };

        login.Show();
    }

    private void ShowDashboard() // SIN async
    {
        var dashboard = _provider.GetRequiredService<Dashboard_Form>();
        dashboard.FormClosed += (_, __) => ExitThread();
        dashboard.Show();
    }
}
