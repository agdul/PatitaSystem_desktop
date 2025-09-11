using PatitaSystem.Dominio.Auth;
using PatitaSystem.Utilidades;

namespace PatitaSystem.Servicios;

/// <summary>
/// Contrato de autenticación hacia la API. 
/// </summary>
public interface IAuthService  // la "I" inicial indica que es una interfaz
{

    //Task<...> // Indica que el método es asíncrono
    //Result<...> // Indica que el método devuelve un resultado envuelto en una clase Result
    //que puede contener:
	    //Éxito: Un objeto LoginResponse con los datos del usuario autenticado.
	    //Error: Un mensaje de error si el login falla.

    /// <summary>Login contra /auth/login</summary>
    Task<Result<LoginResponse>> LoginAsync(LoginRequest request, CancellationToken ct = default);

    /// <summary>Registro contra /auth/registro</summary>
    //Task<Result<bool>> RegisterAsync(RegisterRequest request, CancellationToken ct = default);
}
