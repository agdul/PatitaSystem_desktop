using System.Text.Json.Serialization;


namespace PatitaSystem.Dominio.Producto
{
    public class ProductoResponse
    {
        [JsonPropertyName("id_producto")]
        public int IdProducto { get; set; }

        [JsonPropertyName("nombre_producto")]
        public string NombreProducto { get; set; } = string.Empty;

        [JsonPropertyName("estado_producto")]
        public bool EstadoProducto { get; set; }

        [JsonPropertyName("id_categoria")]
        public int IdCategoria { get; set; }

        [JsonPropertyName("updateAt")]
        public DateTime UpdateAt { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

    }
}
