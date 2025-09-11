using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatitaSystem.Utilidades;

/// <summary>
/// Resultado fuerte de operación: éxito (Value) o error (Error).
/// Evita tirar excepciones para control de flujo.
/// </summary>
public record Result<T>(bool IsSuccess, T? Value, string? Error)
{
    public static Result<T> Ok(T value) => new(true, value, null);
    public static Result<T> Fail(string error) => new(false, default, error);
}
