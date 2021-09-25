using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Ganss.XSS;

namespace WebApplicationCore
{
    public class AntiXssConverter : JsonConverter<string>
    {
        public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var sanitiser = new HtmlSanitizer();
            var raw = reader.GetString();
            var sanitised = sanitiser.Sanitize(raw);

            if (raw == sanitised)
                return sanitised;

            throw new BadRequestException("XSS injection detected.");
        }

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }
}