using PatitaSystem.Dominio.Auth;

namespace PatitaSystem.Dominio.Sesion
{
    /// <summary>
    /// Representa la sesión activa del sistema.
    /// Permite acceder al usuario autenticado en cualquier capa.
    /// </summary>
    public sealed class SesionActual
    {
        /// <summary>
        /// Usuario autenticado actualmente (null si nadie está logueado).
        /// </summary>
        public UsuarioAutenticado? Usuario { get; set; }

        /// <summary>
        /// Indica si hay un usuario en sesión.
        /// </summary>
        public bool EstaAutenticado => Usuario is not null;
    }
}