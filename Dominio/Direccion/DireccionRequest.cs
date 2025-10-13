using System.Text.Json.Serialization;

namespace PatitaSystem.Dominio.Direccion;

public class DireccionRequest
{
    [JsonPropertyName("codigo_postal")]
    public string CodigoPostal { get; set; } = string.Empty;

    [JsonPropertyName("calle")]
    public string Calle { get; set; } = string.Empty;

    [JsonPropertyName("altura")]
    public string Altura { get; set; } = string.Empty;

    [JsonPropertyName("piso")]
    public string? Piso { get; set; }

    [JsonPropertyName("dpto")]
    public string? Dpto { get; set; }

    [JsonPropertyName("id_localidad")]
    public int IdLocalidad { get; set; }

}




