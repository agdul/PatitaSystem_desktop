using PatitaSystem.Infraestructura.Seguridad;
using System.Security.Cryptography;
using System.Text;

namespace PatitaSystem.Infraestructura.Seguridad;

/// <summary>
/// Guarda el token en %LOCALAPPDATA%\PatitaSystem\auth.token cifrado con DPAPI.
/// </summary>
/// sealed: no permite herencia
public sealed class TokenStore : ITokenStore //	TokenStore es una clase que implementa la interfaz ITokenStore.

{
    private const string FileName = "auth.token";
    private readonly string _path =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                     "PatitaSystem", FileName);

    public async Task SaveAsync(string token, CancellationToken ct = default)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(_path)!);
        var bytes = Encoding.UTF8.GetBytes(token);
        var protectedBytes = ProtectedData.Protect(bytes, null, DataProtectionScope.CurrentUser);
        await File.WriteAllBytesAsync(_path, protectedBytes, ct);
    }

    public async Task<string?> LoadAsync(CancellationToken ct = default)
    {
        if (!File.Exists(_path)) return null;
        var protectedBytes = await File.ReadAllBytesAsync(_path, ct);
        var bytes = ProtectedData.Unprotect(protectedBytes, null, DataProtectionScope.CurrentUser);
        return Encoding.UTF8.GetString(bytes);
    }

    public void Clear()
    {
        if (File.Exists(_path)) File.Delete(_path);
    }
}
