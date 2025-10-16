using System.Text.Json.Serialization;

namespace PatitaSystem.Dominio.Direccion
{
    public class DireccionResponse
    {
        [JsonPropertyName("id_direccion")]
        public int IdDireccion { get; set; }

        [JsonPropertyName("id_localidad")]
        public int IdLocalidad { get; set; }

        [JsonPropertyName("codigo_postal")]
        public string? CodigoPostal { get; set; }

        [JsonPropertyName("calle")]
        public string? Calle { get; set; }

        [JsonPropertyName("altura")]
        public string? Altura { get; set; }

        [JsonPropertyName("piso")]
        public string? Piso { get; set; }

        [JsonPropertyName("dpto")]
        public string? Dpto { get; set; }
    }
}



//"id_direccion": 7,
//    "id_localidad": 1,
 //   "codigo_postal": "3400",
 //   "calle": "Quintana",
//    "altura": "158",
  //  "piso": "4",
  //  "dpto": "2"

    //*