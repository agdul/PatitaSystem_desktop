using System.Threading;
using System.Threading.Tasks;

namespace PatitaSystem.Infraestructura.Seguridad;

/// <summary>Persistencia local del JWT (cifrado).</summary>
public interface ITokenStore
{
    Task SaveAsync(string token, CancellationToken ct = default);
    Task<string?> LoadAsync(CancellationToken ct = default);
    void Clear();
}
