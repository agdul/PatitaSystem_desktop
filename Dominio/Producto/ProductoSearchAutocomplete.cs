using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Archivo: Dominio/Producto/ProductoAutocompleteItem.cs
namespace PatitaSystem.Dominio.Producto
{
    /// <summary>
    /// Ítem simple para autocompletar productos.
    /// Mantén este DTO minimalista para que el autocomplete sea liviano.
    /// </summary>
    public sealed class ProductoSearchAutocomplete
    {
        /// <summary>Id del producto.</summary>
        public int IdProducto { get; set; }

        /// <summary>Nombre a mostrar en la lista de sugerencias.</summary>
        public string NombreProducto { get; set; } = string.Empty;

        public override string ToString() => NombreProducto;
    }
}
