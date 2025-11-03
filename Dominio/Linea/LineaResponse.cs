using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PatitaSystem.Dominio.Linea
{
    public class LineaResponse
    {
        [JsonPropertyName("id_linea")]
        public int IdLinea { get; set; }

        [JsonPropertyName("nombre_linea")]
        public string NombreLinea { get; set; } = string.Empty;

        [JsonPropertyName("categorias")]
        public List<CategoriaXLineaResponce> Categorias { get; set; } = new();

        public sealed class CategoriaXLineaResponce
        {
            [JsonPropertyName("id_categoria")]
            public int IdCategoria { get; set; }

            [JsonPropertyName("nombre_categoria")]
            public string NombreCategoria { get; set; } = string.Empty;
        }

    }
}
