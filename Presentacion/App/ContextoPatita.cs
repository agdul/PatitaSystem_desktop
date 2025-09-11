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
        ShowLogin();
    }
    private bool _navegandoADashboard;

    private void ShowLogin()
    {
        var login = _provider.GetRequiredService<Login_Form>(); // obtenemos el formulario Login_Form desde el contenedor de servicios , instancias de formulario

        login.LoginSucceeded += async (_, __) =>
        {
            // Recuperamos el token store para verificar que el token se haya guardado
            var tokenStore = _provider.GetRequiredService<ITokenStore>();

            // Verificamos que el token se haya guardado correctamente
            var token = await tokenStore.LoadAsync();
            if (string.IsNullOrWhiteSpace(token))
            {
                MessageBox.Show("No se encontró token tras el login.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _navegandoADashboard = true; // Indicamos que estamos navegando al dashboard

            // Ocultamos el formulario de login y mostramos el dashboard
            login.Hide();

            // Mostramos el dashboard
            ShowDashboard();
            
        };


        login.FormClosed += (_, __) => // 
        {
            if (!_navegandoADashboard)
                ExitThread();
        };

        login.Show();
    }

    private void ShowDashboard() 
    {
        try { 
           var dashboard = _provider.GetRequiredService<Dashboard_Form>();
           dashboard.FormClosed += (_, __) => ExitThread();
           dashboard.Show();
        } 
        catch (Exception ex) { 
              MessageBox.Show($"No se pudo abrir el dashboard: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
