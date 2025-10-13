// Archivo: Presentacion/Forms/FormRegistrarUsuario.cs
using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using PatitaSystem.Dominio.Usuarios;   // DTOs (UsuarioCreateRequest, UsuarioUpdateRequest, UsuarioDetalleDto)
using PatitaSystem.Dominio.Direccion; // DTOs (DireccionCreateRequest)
using PatitaSystem.Infraestructura.Http; // UsuarioApiClient

namespace PatitaSystem.Presentacion.Forms
{
    /// <summary>
    /// Alta/Edición de usuarios.
    /// - Si _usuarioId == null → CREAR (POST /usuario/)
    /// - Si _usuarioId != null → EDITAR (PUT /usuario/:id) y precarga datos (GET /usuario/:id)
    /// </summary>
    public partial class FormRegistrarUsuario : MaterialForm
    {
        private readonly UsuarioApiClient? _usuarioApi; // Inyectado desde FormAdministrador
        private readonly DireccionApiClient? _direccionApi; // Inyectado desde FormAdministrador
        private readonly int? _usuarioId;               // null = crear, valor = editar

        // ==== Constructor para el diseñador ====
        public FormRegistrarUsuario()
        {
            InitializeComponent();

            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(
                Primary.Teal700, Primary.Teal900, Primary.Teal500,
                Accent.Green200, TextShade.WHITE
            );

            InicializarComboRoles();
            InicializarComboGeneros();
        }

        // ==== Constructor: CREAR (inyecta Usuario + Direccion) ====
        public FormRegistrarUsuario(UsuarioApiClient usuarioApi, DireccionApiClient direccionApi) : this()
        {
            _usuarioApi = usuarioApi ?? throw new ArgumentNullException(nameof(usuarioApi));
            _direccionApi = direccionApi ?? throw new ArgumentNullException(nameof(direccionApi));

            Text = "Crear usuario";
            BTN_GuardarUsuario.Text = "Crear usuario";
        }

        // ==== Constructor: EDITAR (inyecta ambos y prellena) ====
        public FormRegistrarUsuario(UsuarioApiClient usuarioApi, DireccionApiClient direccionApi, FormAdministrador.Usuario usuario)
            : this(usuarioApi, direccionApi)   // <<<<< FIX: encadenar al ctor correcto
        {
            _usuarioId = int.TryParse(usuario.Id, out var idVal) ? idVal : null;
            Text = "Editar usuario";
            BTN_GuardarUsuario.Text = "Guardar cambios";

            this.Shown -= FormRegistrarUsuario_Shown;
            this.Shown += FormRegistrarUsuario_Shown;
        }

        /// <summary>Carga detalle del usuario (GET /usuario/:id) y prellena controles.</summary>
        private async void FormRegistrarUsuario_Shown(object? sender, EventArgs e)
        {
            if (_usuarioApi is null || !_usuarioId.HasValue) return;

            try
            {
                using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(20));
                var det = await _usuarioApi.GetUsuarioDetalleByIdAsync(_usuarioId.Value, cts.Token);
                if (det is null) return;

                // Datos básicos
                TXTB_Nombre.Text = det.Nombre ?? "";
                TXTB_Apellido.Text = det.Apellido ?? "";
                TXTB_Dni.Text = det.Dni ?? "";
                TXTB_Mail.Text = det.Email ?? "";
                TXTB_Celular.Text = det.Celular ?? "";

                if (det.FechaNacimiento.HasValue)
                    DTP_Nacimiento.Value = det.FechaNacimiento.Value;

                // Rol (map index <- id)
                if (det.Rol is not null)
                {
                    MCB_Rol.StartIndex = det.Rol.IdRol switch
                    {
                        1 => 0, // Administrador
                        2 => 1, // Vendedor
                        3 => 2, // Estilista
                        _ => MCB_Rol.StartIndex
                    };
                }

                // Dirección (si mostrás estos campos)
                if (det.Direccion is not null)
                {
                    TXTB_CodigoPostal.Text = det.Direccion.CodigoPostal ?? "";
                    TXTB_Calle.Text = det.Direccion.Calle ?? "";
                    TXTB_Altura.Text = det.Direccion.Altura ?? "";
                    TXTB_Piso.Text = det.Direccion.Piso ?? "";
                    TXTB_Dpto.Text = det.Direccion.Dpto ?? "";
                }
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Timeout al cargar el detalle del usuario.", "Usuarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo obtener el detalle del usuario.\n\n{ex.Message}",
                    "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al cargar el detalle:\n{ex}",
                    "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ------------------------------------------------------------------------------------
        // =================================
        //  Inicialización de boxs combos
        // =================================

        private void InicializarComboRoles()
        {
            if (MCB_Rol.Items.Count == 0)
            {
                // Orden fijo para mapear: 1-Admin, 2-Vendedor, 3-Estilista
                MCB_Rol.Items.Add("Administrador");
                MCB_Rol.Items.Add("Vendedor");
                MCB_Rol.Items.Add("Estilista");
                MCB_Rol.StartIndex = 1; // por defecto Vendedor
            }
        }

        private void InicializarComboGeneros()
        {
            if (MCB_Genero.Items.Count == 0)
            {
                MCB_Genero.Items.Add("Masculino");
                MCB_Genero.Items.Add("Femenino");
                MCB_Genero.Items.Add("Otro");
                MCB_Genero.StartIndex = 0; // por defecto Masculino
            }
        }

        // ------------------------------------------------------------------------------------

        // ------------------------------------------------------------------------------------
        //                     Helperes
        // ------------------------------------------------------------------------------------

        private int ObtenerIdRol() => MCB_Rol.SelectedIndex switch
        {
            0 => 1, // Administrador
            1 => 2, // Vendedor
            2 => 3, // Estilista
            _ => 2
        };

        private int ObtenerIdGenero() => MCB_Genero.SelectedIndex switch
        {
            0 => 1, // Masculino
            1 => 2, // Femenino
            2 => 3, // Otro
            _ => 1
        };

        // ------------------------------------------------------------------------------------
    

        /// <summary>
        /// Valida campos. Si es creación (no hay _usuarioId), exige contraseña.
        /// </summary>
        private bool ValidarCampos(out string mensaje)
        {
            if (string.IsNullOrWhiteSpace(TXTB_Nombre.Text))
            { mensaje = "El nombre es obligatorio."; return false; }

            if (string.IsNullOrWhiteSpace(TXTB_Apellido.Text))
            { mensaje = "El apellido es obligatorio."; return false; }

            if (string.IsNullOrWhiteSpace(TXTB_Dni.Text))
            { mensaje = "El DNI es obligatorio."; return false; }

            if (string.IsNullOrWhiteSpace(TXTB_Mail.Text))
            { mensaje = "El email es obligatorio."; return false; }

            // Password sólo para CREAR
            if (!_usuarioId.HasValue)
            {
                if (string.IsNullOrWhiteSpace(TXTB_Password.Text) || TXTB_Password.Text.Length < 6)
                { mensaje = "La contraseña es obligatoria (mínimo 6)."; return false; }
            }

            mensaje = "";
            return true;
        }

        private string DerivarNombreUsuario()
        {
            var mail = TXTB_Mail.Text?.Trim() ?? "";
            if (mail.Contains("@"))
            {
                var at = mail.IndexOf('@');
                if (at > 0) return mail[..at];
            }
            var baseName = (TXTB_Nombre.Text + TXTB_Apellido.Text).Trim().ToLowerInvariant();
            return string.IsNullOrWhiteSpace(baseName) ? "usuario" : baseName.Replace(" ", "");
        }

        private void TXTB_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
        private void TXTB_Celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
        private void TXTB_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }
        private void TXTB_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        // ========================
        //  Guardar (Crear / Editar)
        // ========================

        /// <summary>
        /// Click en “Guardar Usuario”.
        /// - Si _usuarioId == null → POST /usuario/
        /// - Si _usuarioId != null → PUT  /usuario/:id
        /// </summary>
        private async void BTN_Crear_Click(object sender, EventArgs e)
        {
            if (_usuarioApi is null)
            {
                MessageBox.Show("No se inicializó el cliente de API. Abra este formulario desde el Administrador.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarCampos(out var msg))
            {
                MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BTN_GuardarUsuario.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                if (_usuarioId.HasValue)
                {
                    // ===== EDITAR (PUT) =====

                    var reqDireccion = new DireccionRequest
                    {
                        Calle = TXTB_Calle.Text.Trim(),
                        Altura = TXTB_Altura.Text.Trim(),
                        Piso = TXTB_Piso.Text.Trim(),
                        Dpto = TXTB_Dpto.Text.Trim(),
                        CodigoPostal = TXTB_CodigoPostal.Text.Trim(),
                        IdLocalidad = 1 // TODO: combo de localidad
                    };

                    var direccionActualizada = await _direccionApi!.ActualizarAsync(1, reqDireccion);




                    var reqUsuario = new UsuarioUpdateRequest
                    {
                        IdDireccion = 1, // TODO: usar la real cuando implementes alta de dirección
                        IdGenero = ObtenerIdGenero(), // TODO: combo de género
                        Dni = TXTB_Dni.Text.Trim(),
                        Apellido = TXTB_Apellido.Text.Trim(),
                        Nombre = TXTB_Nombre.Text.Trim(),
                        NombreUsuario = TXTB_Usuario.Text.Trim(),  // o textbox "usuario" si lo agregás
                        Email = TXTB_Mail.Text.Trim(),
                        FechaNacimiento = DTP_Nacimiento.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Celular = TXTB_Celular.Text.Trim()
                    };

                    var actualizado = await _usuarioApi.UpdateUsuarioAsync(_usuarioId.Value, reqUsuario);

                    MessageBox.Show($"Usuario actualizado (ID: {actualizado.IdUsuario}).",
                        "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // ===== CREAR (POST) =====
                    // Para crear un usuario, necesito primero crear la direccion , una vez creada la direccion
                    // Obtengo su ID y lo uso para crear el usuario con ese ID de direccion recien creado.

                    var direccion = new DireccionRequest
                    {
                        Calle = TXTB_Calle.Text.Trim(),
                        Altura = TXTB_Altura.Text.Trim(),
                        Piso = TXTB_Piso.Text.Trim(),
                        Dpto = TXTB_Dpto.Text.Trim(),
                        CodigoPostal = TXTB_CodigoPostal.Text.Trim(),
                        IdLocalidad = 1 // TODO: combo de localidad
                    };

                    if (_direccionApi is null)
                    {
                        MessageBox.Show("No se inicializó el cliente de API de Direcciones. Abra este formulario desde el Administrador.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var direccionCreada = await _direccionApi.CrearAsync(direccion);

                    if (direccionCreada is null)
                    {
                        MessageBox.Show("No se pudo crear la dirección para el usuario.",
                         "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var req = new UsuarioCreateRequest
                    {
                        IdDireccion = direccionCreada.IdDireccion,
                        IdRol = ObtenerIdRol(),
                        IdGenero = 1,
                        Dni = TXTB_Dni.Text.Trim(),
                        Apellido = TXTB_Apellido.Text.Trim(),
                        Nombre = TXTB_Nombre.Text.Trim(),
                        NombreUsuario = TXTB_Usuario.Text.Trim(),
                        Password = TXTB_Password.Text,
                        Email = TXTB_Mail.Text.Trim(),
                        Estado = true,
                        FechaNacimiento = DTP_Nacimiento.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Celular = TXTB_Celular.Text.Trim()
                    };

                    var creado = await _usuarioApi.CreateUsuarioAsync(req);

                    MessageBox.Show($"Usuario creado correctamente (ID: {creado.IdUsuario}).",
                        "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Timeout al guardar el usuario.", "Usuarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo guardar el usuario.\n\n{ex.Message}",
                    "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al guardar usuario:\n{ex}",
                    "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                BTN_GuardarUsuario.Enabled = true;
                Cursor = Cursors.Default;
            }
        }


    }
}
