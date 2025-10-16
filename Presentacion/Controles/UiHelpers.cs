// Archivo: Presentacion/Controles/UiHelpers.cs
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatitaSystem.Presentacion.Commons
{
    /// <summary>
    /// Helpers de UI para operaciones async (deshabilitar controles, capturar errores, etc.).
    /// </summary>
    internal static class UiHelpers
    {
        public static async Task RunSafeAsync(Control owner, Control[] toDisable, Func<Task> action)
        {
            try
            {
                foreach (var c in toDisable) c.Enabled = false;
                owner.Cursor = Cursors.WaitCursor;
                await action().ConfigureAwait(true);
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show(owner, "Operación cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(owner, $"Error de API: {ex.Message}", "API", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(owner, $"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                owner.Cursor = Cursors.Default;
                foreach (var c in toDisable) c.Enabled = true;
            }
        }
    }
}
