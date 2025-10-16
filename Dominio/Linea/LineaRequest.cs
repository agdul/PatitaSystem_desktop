using System.Text.Json.Serialization;

namespace PatitaSystem.Dominio.Linea
{

    internal sealed class LineaRequest
    {
        //[JsonPropertyName("id_linea")]
        //public int IdLinea { get; set; }

        [JsonPropertyName("nombre_linea")]
        public string NombreLinea { get; set; } = string.Empty;

    }


}