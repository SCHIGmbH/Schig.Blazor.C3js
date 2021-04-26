using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models.JsonConverters
{
    public class EmptyLabelTextOptionsJsonConverter : JsonConverter<EmptyLabelTextOptions>
    {
        public override EmptyLabelTextOptions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(Utf8JsonWriter writer, EmptyLabelTextOptions value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("label");
            writer.WriteStartObject();
            writer.WriteString("text", value.Text);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
