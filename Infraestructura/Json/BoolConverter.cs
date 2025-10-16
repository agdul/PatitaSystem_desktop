// Archivo: Infraestructura/Json/FlexibleBoolConverter.cs
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PatitaSystem.Infraestructura.Json
{
    /// <summary>
    /// Convierte 0/1, "0"/"1", "true"/"false", "si"/"no" a bool.
    /// </summary>
    public sealed class FlexibleBoolConverter : JsonConverter<bool>
    {
        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.True: return true;
                case JsonTokenType.False: return false;
                case JsonTokenType.Number:
                    if (reader.TryGetInt64(out var n)) return n != 0;
                    if (reader.TryGetDouble(out var d)) return Math.Abs(d) > double.Epsilon;
                    break;
                case JsonTokenType.String:
                    var s = reader.GetString()?.Trim().ToLowerInvariant();
                    if (string.IsNullOrEmpty(s)) return false;
                    if (s is "true" or "t" or "yes" or "y" or "si" or "sí" or "1") return true;
                    if (s is "false" or "f" or "no" or "n" or "0") return false;
                    break;
            }
            throw new JsonException("Valor incompatible para booleano.");
        }

        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
            => writer.WriteBooleanValue(value);
    }
}
