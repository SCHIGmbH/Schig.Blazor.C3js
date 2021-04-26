using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models.JsonConverters
{
    public class CullingOptionsJsonConverter : JsonConverter<CullingOptions>
    {
        public override CullingOptions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, CullingOptions value, JsonSerializerOptions options)
        {
            if(value.IsCulling)
            {
                writer.WriteStartObject();
                writer.WriteNumber("max", value.Max);
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteBooleanValue(false);
            }
        }
    }
}
