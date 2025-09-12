

namespace PatitaSystem.Dominio.Auth
{
    public sealed class UsuarioAutenticado
    {
        public int IdUsuario { get; init; }
        public int IdRol { get; init; }
        public string ApellidoUsuario { get; init; } = string.Empty;
        public string NombreUsuario { get; init; } = string.Empty;
        public string Usuario { get; init; } = string.Empty;
        public string RolNombre => Roles.ATexto(IdRol);
        public string Token { get; init; } = string.Empty;




    }
}
