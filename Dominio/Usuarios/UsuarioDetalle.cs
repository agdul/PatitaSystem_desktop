// Archivo: Dominio/Usuarios/UsuarioDetalleDto.cs
using System;
using System.Text.Json.Serialization;

namespace PatitaSystem.Dominio.Usuarios
{
    /// <summary>
    /// DTO de detalle para GET /usuario/:id (incluye rol, género y dirección anidados).
    /// </summary>
    public sealed class UsuarioDetalleDto
    {
        [JsonPropertyName("id_usuario")]
        public int IdUsuario { get; set; }

        [JsonPropertyName("dni_usuario")]
        public string? Dni { get; set; }

        [JsonPropertyName("apellido_usuario")]
        public string? Apellido { get; set; }

        [JsonPropertyName("nombre_usuario")]
        public string? Nombre { get; set; }

        [JsonPropertyName("usuario")]
        public string? NombreUsuario { get; set; }

        [JsonPropertyName("email_usuario")]
        public string? Email { get; set; }

        [JsonPropertyName("estado_usuario")]
        public bool Estado { get; set; }

        /// <summary>Viene como ISO, ej: "1998-05-20T00:00:00.000Z".</summary>
        [JsonPropertyName("fec_nac")]
        public string? FechaNacimientoIso { get; set; }

        [JsonIgnore]
        public DateTime? FechaNacimiento =>
            DateTime.TryParse(FechaNacimientoIso, out var d) ? d : null;

        [JsonPropertyName("celular_usuario")]
        public string? Celular { get; set; }

        [JsonPropertyName("rol")]
        public RolDto? Rol { get; set; }

        [JsonPropertyName("genero")]
        public GeneroDto? Genero { get; set; }

        [JsonPropertyName("direccion")]
        public DireccionDto? Direccion { get; set; }
    }

    public sealed class RolDto
    {
        [JsonPropertyName("id_rol")]
        public int IdRol { get; set; }

        [JsonPropertyName("nombre_rol")]
        public string? Nombre { get; set; }
    }

    public sealed class GeneroDto
    {
        [JsonPropertyName("id_genero")]
        public int IdGenero { get; set; }

        [JsonPropertyName("nombre_genero")]
        public string? Nombre { get; set; }
    }

    public sealed class DireccionDto
    {
        [JsonPropertyName("id_direccion")]
        public int IdDireccion { get; set; }

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

        [JsonPropertyName("localidad")]
        public LocalidadDto? Localidad { get; set; }
    }

    public sealed class LocalidadDto
    {
        [JsonPropertyName("id_localidad")]
        public int IdLocalidad { get; set; }

        [JsonPropertyName("nombre_localidad")]
        public string? Nombre { get; set; }

        [JsonPropertyName("provincia")]
        public ProvinciaDto? Provincia { get; set; }
    }

    public sealed class ProvinciaDto
    {
        [JsonPropertyName("id_provincia")]
        public int IdProvincia { get; set; }

        [JsonPropertyName("nombre_provincia")]
        public string? Nombre { get; set; }
    }
}
