using System.Text.Json.Serialization;

namespace PatitaSystem.Dominio.Presentacion
{
    public class PresentacionResponse
    {

        [JsonPropertyName("id_producto")]
        public int IdProducto { get; set; }

        [JsonPropertyName("nombre_presentacion")]
        public string NombrePresentacion { get; set; } = string.Empty;

        [JsonPropertyName("descripcion")]
        public string Descripcion { get; set; } = string.Empty;

        [JsonPropertyName("stock")]
        public int Stock { get; set; }

        //precio_compra
        [JsonPropertyName("precio_compra")]
        public decimal PrecioCompra { get; set; }

        //porcentaje_aumento
        [JsonPropertyName("porcentaje_aumento")]
        public decimal PorcentajeAumento { get; set; }

        public List<PoductoXPresentacion> Producto { get; set; } = new();

        public sealed class PoductoXPresentacion
        {
            [JsonPropertyName("id_producto")]
            public int IdProducto { get; set; }
            [JsonPropertyName("nombre_producto")]
            public string NombreProducto { get; set; } = string.Empty;
            //estado_producto
            [JsonPropertyName("estado_producto")]
            public bool EstadoProducto { get; set; }
        }


    }
}
