// Archivo: Presentacion/Controles/SuggestTextBox.cs
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace PatitaSystem.Presentacion.Controles
{
    /// <summary>
    /// SuggestTextBox
    /// TextBox con lista flotante de sugerencias (autocomplete asíncrono).
    /// - Debounce configurable.
    /// - Cancelación de búsquedas previas.
    /// - Navegación con ↑/↓ y selección con Enter o clic.
    /// - Exposición del item seleccionado (Id + Display).
    /// </summary>
    public class SuggestTextBox : UserControl
    {
        // ----- Tipos públicos -----
        public sealed class SuggestItem
        {
            public int Id { get; }
            public string Display { get; }
            public SuggestItem(int id, string display) { Id = id; Display = display; }
            public override string ToString() => Display;
        }

        // ----- UI interna -----
        private readonly MaterialTextBox2 _txt = new() { Dock = DockStyle.Fill, Hint = "Escribí para buscar...", TabStop = true };
        private readonly ListBox _list = new() { Visible = false, IntegralHeight = true, BorderStyle = BorderStyle.FixedSingle };

        // ----- Estado -----
        private Func<string, Task<List<SuggestItem>>>? _searchFunc;
        private CancellationTokenSource? _cts;
        private readonly System.Windows.Forms.Timer _debounce;
        private int _debounceMs = 250; // por defecto
        private SuggestItem? _selectedItem;

        public SuggestTextBox()
        {
            this.Height = 48;
            this.MinimumSize = new Size(150, 48);
            this.Controls.Add(_txt);

            // lista flotante (se agrega al mismo parent cuando se crea el handle)
            _list.Font = _txt.Font;
            _list.TabStop = false; // para no romper el tab order
            _list.Click += (_, __) => CommitSelectionFromList();
            _list.DoubleClick += (_, __) => CommitSelectionFromList();
            _list.LostFocus += (_, __) => HideList();

            _txt.KeyDown += Txt_KeyDown;
            _txt.TextChanged += Txt_TextChanged;
            _txt.LostFocus += (_, __) =>
            {
                // si el foco se fue a la lista, no cerrar
                if (!_list.Focused) HideList();
            };

            _debounce = new System.Windows.Forms.Timer { Interval = _debounceMs };
            _debounce.Tick += async (_, __) =>
            {
                _debounce.Stop();
                await RunSearchAsync(_txt.Text);
            };

            this.HandleCreated += (_, __) =>
            {
                if (this.Parent != null && !_list.IsHandleCreated)
                {
                    this.Parent.Controls.Add(_list);
                    _list.BringToFront();
                }
            };

            this.Resize += (_, __) => PositionList();
            this.LocationChanged += (_, __) => PositionList();
        }

        // ===== API pública =====
        /// <summary>Asigna la función de búsqueda asíncrona.</summary>
        public void SetSearchFunc(Func<string, Task<List<SuggestItem>>> searchFunc) => _searchFunc = searchFunc;

        /// <summary>Tiempo de espera antes de disparar la búsqueda (ms). Default 250.</summary>
        public int DebounceMilliseconds
        {
            get => _debounceMs;
            set { _debounceMs = Math.Max(0, value); _debounce.Interval = _debounceMs; }
        }

        /// <summary>Texto del input.</summary>
        public string InputText
        {
            get => _txt.Text;
            set => _txt.Text = value ?? string.Empty;
        }

        /// <summary>Item seleccionado (Id + Display). Es null si el usuario no confirmó una sugerencia.</summary>
        public SuggestItem? SelectedItem
        {
            get => _selectedItem;
            private set
            {
                _selectedItem = value;
                SelectedItemChanged?.Invoke(this, value);
            }
        }

        /// <summary>Disparado cuando cambia el item seleccionado.</summary>
        public event EventHandler<SuggestItem?>? SelectedItemChanged;

        // ===== Lógica interna =====
        private void Txt_TextChanged(object? sender, EventArgs e)
        {
            SelectedItem = null; // si cambió el texto manualmente, invalidar selección previa
            if (_searchFunc == null) return;

            // reiniciar debounce
            _debounce.Stop();
            _debounce.Start();
        }

        private async Task RunSearchAsync(string term)
        {
            if (_searchFunc == null) return;

            _cts?.Cancel();
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            try
            {
                if (string.IsNullOrWhiteSpace(term))
                {
                    HideList();
                    return;
                }

                var results = await _searchFunc(term.Trim());
                if (token.IsCancellationRequested) return;

                _list.BeginUpdate();
                _list.Items.Clear();
                if (results != null && results.Count > 0)
                {
                    foreach (var r in results) _list.Items.Add(r);
                    ShowList();
                }
                else
                {
                    HideList();
                }
                _list.EndUpdate();
            }
            catch
            {
                HideList();
                // opcional: loggear
            }
        }

        private void ShowList()
        {
            PositionList();
            _list.Visible = true;
            _list.Height = Math.Min(200, Math.Max(50, _list.PreferredHeight));
            _list.BringToFront();
        }

        private void HideList()
        {
            _list.Visible = false;
        }

        private void PositionList()
        {
            if (this.Parent == null) return;

            var pt = this.Parent.PointToClient(this.PointToScreen(new Point(0, this.Height)));
            _list.Location = pt;
            _list.Width = this.Width;
        }

        private void Txt_KeyDown(object? sender, KeyEventArgs e)
        {
            if (!_list.Visible)
            {
                if (e.KeyCode == Keys.Down && _list.Items.Count > 0)
                {
                    ShowList();
                    _list.SelectedIndex = 0;
                    _list.Focus();
                    e.Handled = true;
                }
                return;
            }

            if (e.KeyCode == Keys.Down)
            {
                if (_list.SelectedIndex < _list.Items.Count - 1)
                    _list.SelectedIndex++;
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (_list.SelectedIndex > 0)
                    _list.SelectedIndex--;
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                CommitSelectionFromList();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                HideList();
                e.Handled = true;
            }
        }

        private void CommitSelectionFromList()
        {
            if (_list.SelectedItem is SuggestItem it)
            {
                SelectedItem = it;
                _txt.Text = it.Display;
                _txt.SelectionStart = _txt.Text.Length;
            }
            HideList();
            _txt.Focus();
        }
    }
}
