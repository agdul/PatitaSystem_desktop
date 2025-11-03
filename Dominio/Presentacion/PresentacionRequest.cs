using System.Text.Json.Serialization;

namespace PatitaSystem.Dominio.Presentacion
{
    public class PresentacionRequest
    {
        //id_producto
        [JsonPropertyName("id_producto")]
        public int IdProducto { get; set; } = 0;

        //nombre_presentacion
        [JsonPropertyName("nombre_presentacion")]
        public string NombrePresentacion { get; set; } = string.Empty;

        //descripcion
        [JsonPropertyName("descripcion")]
        public string Descripcion { get; set; } = string.Empty;

        //stock
        [JsonPropertyName("stock")]
        public int Stock { get; set; } = 0;

        //precio_compra
        [JsonPropertyName("precio_compra")]
        public decimal PrecioCompra { get; set; } = 0m;

        //porcentaje_aumento
        [JsonPropertyName("porcentaje_aumento")]
        public decimal PorcentajeAumento { get; set; } = 0m;






    }
}
