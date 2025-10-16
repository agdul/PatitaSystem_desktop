using System.Text.Json.Serialization;


namespace PatitaSystem.Dominio.Producto
{
    public class ProductoRequest
    {

        [JsonPropertyName("nombre_producto")]
        public string NombreProducto { get; set; } = string.Empty;

        [JsonPropertyName("id_linea")]
        public int IdLinea { get; set; } 

        [JsonPropertyName("id_categoria")]
        public int IdCategoria { get; set; }


    }
}
