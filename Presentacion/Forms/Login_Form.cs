using MaterialSkin;
using MaterialSkin.Controls;
using PatitaSystem.Dominio.Auth;
using PatitaSystem.Dominio.Sesion;
using PatitaSystem.Servicios;
using PatitaSystem.Utilidades;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Threading;

namespace PatitaSystem;
public partial class Login_Form : MaterialForm
{

    // ------------------------------------------------------------
    // Dependencias inyectadas 
    // ------------------------------------------------------------

    private readonly IAuthService _auth; //variable privada que guarda el servicio de autenticación
    //Permite que el formulario pueda llamar a la API para verificar usuario y contraseña usando el método LoginAsync.

    public readonly SesionActual _sesion; // Mantener la sesión actual del usuario autenticado

    // ------------------------------------------------------------
    // Estado interno para cancelar requests
    // ------------------------------------------------------------

    //La inicializo para evitar null en el primer uso.
    private CancellationTokenSource _cts = new(); // controlar el tiempo de espera (timeout) de la operación de login


    //Evento que el ContextoPatita escuchara: 
    //Se dispara cuando el login fue exitoso, para avisar al resto de la aplicación
    public event EventHandler? LoginSucceeded;

    // 2) ***Constructor para RUNTIME (DI)***
    //Este es el que realmente se usa cuando la app corre.
    //Recibe el servicio de autenticación (IAuthService) por inyección de dependencias.

    /// <summary>
    /// Constructor: inyectamos SesionActual + AuthService desde DI.
    /// </summary>
    public Login_Form(IAuthService auth, SesionActual sesion)
    {
        _auth = auth ?? throw new ArgumentNullException(nameof(auth));
        _sesion = sesion ?? throw new ArgumentNullException(nameof(sesion));


        InitializeComponent();     // todo el diseño lo hacés en el Designer


        if (!DesignMode)           // evita ejecutar skin en el diseñador de VS
        {
            ConfigurarMaterialSkin();
            WireEvents();          //  acá engancho los eventos 
        }
        this.MinimumSize = new Size(488, 556);
        this.MaximumSize = new Size(488, 556);

    }

    // 3) ***Constructor para el DISEÑADOR*** (no se usa en runtime)
    public Login_Form()
    {
        InitializeComponent();
        // controlan cómo se comporta el formulario cuando lo abre el diseñador de Visual Studio versus,
        // cuando se ejecuta la aplicación normalmente
        // Importantísimo: cuando lo abre el diseñador, salimos temprano.
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            return; // termina el constructor temprano, evitando ejecutar lógica que solo tiene sentido en tiempo de ejecución.

        // Si ejecutaras esta ruta en runtime sería un error:
        throw new InvalidOperationException("No usar el ctor sin DI en runtime. El Program.cs debe resolver Login_Form desde el ServiceProvider.");
    }


    private void ConfigurarMaterialSkin()
    {
        var skin = MaterialSkinManager.Instance;
        skin.AddFormToManage(this);

        // Elegí el tema y paleta que te gustó
        skin.Theme = MaterialSkinManager.Themes.DARK;
        skin.ColorScheme = new ColorScheme(
            Primary.Teal700, Primary.Teal900, Primary.Teal500,
            Accent.Green200, TextShade.WHITE
        );
        // Opcional:
        // skin.EnforceBackcolorOnAllComponents = true;
    }

    private void WireEvents() //Cableado de eventos
    {
        // Defino los botones 
        this.AcceptButton = BTN_Ingresar;  
        this.CancelButton = BTN_Salir;

        // Cuando el usuario cambia el estado del switch, se ejecuta el código dentro.
        SWCH_Password.CheckedChanged += (s, e) =>
        {
            // Cambiá UseSystemPasswordChar por Password
            TXTB_Password.Password = !SWCH_Password.Checked;
            TXTB_Password.Refresh();
        };

        // Estado inicial oculto
        TXTB_Password.Password = true;

        BTN_Ingresar.Click += async (s, e) => await OnIngresarAsync(); // clic en "Ingresar", ejecuta el método de login.
        BTN_Salir.Click += (s, e) => this.Close();
    }

    // Función se usa para habilitar o deshabilitar la interfaz de usuario (UI) durante el proceso de autenticación
    private void ToggleUi(bool enabled) { 
        TXTB_Usuario.Enabled = enabled;
        TXTB_Password.Enabled = enabled;
        BTN_Ingresar.Enabled = enabled;
        BTN_Salir.Enabled = enabled;
        SWCH_Password.Enabled = enabled;
    }

    // Sencarga de gestionar todo el proceso de login en el Formulario de Login
    private async Task OnIngresarAsync() // El BTN_Ingresar 
    {
        ReiniciarToken(15); // Reinicia el token de cancelación con un timeout de 15 segundos

        // Obtengo los input de usuario y password
        var user = TXTB_Usuario.Text.Trim(); // Saco los espacios al inicio y final
        var pass = TXTB_Password.Text;

        // Validacion simple de que no este vacío usaurio
        if (string.IsNullOrWhiteSpace(user))
        {
            MessageBox.Show("Ingresá tu usuario.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        // Validacion simple de que no este vacío password
        if (string.IsNullOrWhiteSpace(pass))
        {
            MessageBox.Show("Ingresá tu contraseña.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        ToggleUi(false); // Deshabilita la interfaz mientras se procesa el login
        try
        {
            var req = new LoginRequest // Prepara los datos para enviar a la API.
            {
                // 
                Usuario = user,
                Password = pass
            };
            // VER SI LIMPIAR ACA DENUEVO
            _cts?.Cancel(); // Si ya hay una operación de login en curso, la cancela.
            _cts = new CancellationTokenSource(TimeSpan.FromSeconds(15)); // Timeout de 15 segundos

            // ----------------------------------------------------------------------

            // Aca pasa la magia:
            //var result = await _auth.LoginAsync(req, _cts.Token); //Llama al servicio de autenticación de forma asíncrona y el resultado lo guarda en result
            // Llama al servicio de autenticación de forma asíncrona y el resultado lo guarda en result
            // IMPORTANTE: el servicio devuelve Result<LoginResponse>
            Result<LoginResponse> result = await _auth.LoginAsync(req, _cts.Token);
            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Error ?? "Error de autenticación.",
                    "Login fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ----------------------------------------------------------------------

            // Desempaquetamos y mapeamos : loginResponse → UsuarioAtenticado
            var loginResponse = result.Value!;
            if (loginResponse is null || loginResponse.User is null)
            {
                MessageBox.Show("Respuesta inválida del servidor.",
                    "Login fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // ----------------------------------------------------------------------

            // Guardamos en sesión. importante : para el dashboard 
            _sesion.Usuario = MapearAUsuarioAutenticado(loginResponse);


            // ----------------------------------------------------------------------

            // Acá notificamos al ApplicationContext
            LoginSucceeded?.Invoke(this, EventArgs.Empty);
        }
        catch (OperationCanceledException)
        {
            MessageBox.Show("Timeout al intentar ingresar.",
                "Tiempo agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error inesperado: {ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            ToggleUi(true);
        }
    }

    // Mapea LoginResponse (DTO) a UsuarioAutenticado (modelo de dominio)
    /// <summary>
    /// Convierte el DTO de respuesta del login (tal como llega de la API)
    /// al modelo de dominio UsuarioAutenticado (usado en el resto de la app).
    /// </summary>
    private static UsuarioAutenticado MapearAUsuarioAutenticado(LoginResponse dto)
    {
        // Asumo tu estructura (según el JSON que pegaste):
        // dto.user.id_usuario, dto.user.id_rol, dto.user.apellido_usuario, dto.user.nombre_usuario, dto.user.token
        var u = dto.User!;

        // ⚠️ Importante: los IDs de rol deben coincidir con tu BD actual.
        // Según tu ejemplo: 1=Admin, 2=Cajera, 3=Estilista
        return new UsuarioAutenticado
        {
            IdUsuario = u.IdUsuario,
            IdRol = u.IdRol,
            Usuario = u.Usuario,
            NombreUsuario = u.NombreUsuario,
            ApellidoUsuario = u.ApellidoUsuario,
            Token = u.Token ?? string.Empty
        };
    }

    // ---------------------------------------------------------------------
    // Limpieza de recursos del formulario
    // ---------------------------------------------------------------------
    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        try { _cts?.Cancel(); } catch { /* ignorar */ }
        _cts?.Dispose();
    }


    // ------------------------------------------------------------
    // Utilidad: reiniciar token de cancelación de forma segura
    // ------------------------------------------------------------
    /// <summary>
    /// Cancela y dispone el token previo (si lo hay) y crea uno nuevo con timeout.
    /// </summary>
    private void ReiniciarToken(int segundosTimeout)
    {
        try { _cts.Cancel(); } catch { /* ignorar si ya fue cancelado */ }
        _cts.Dispose();
        _cts = new CancellationTokenSource(TimeSpan.FromSeconds(segundosTimeout));
    }

    public class RoundedMaterialCard : MaterialCard
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radius = 40; // Ajustá el radio para más o menos redondeo
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
    }

}








