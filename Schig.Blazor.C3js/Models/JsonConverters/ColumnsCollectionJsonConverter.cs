using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models.JsonConverters
{
    public class ColumnsCollectionJsonConverter : JsonConverter<ColumnsCollection>
    {
        public override ColumnsCollection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(Utf8JsonWriter writer, ColumnsCollection value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            writer.WriteStringValue(value.Key);
            for (int i = 0; i < value.Values.Length; i++)
            {
                if (value.Values[i] is string @string)
                {
                    writer.WriteStringValue(@string);
                }

                if (value.Values[i] is int @int)
                {
                    writer.WriteNumberValue(@int);
                }
            }
            writer.WriteEndArray();
        }
    }
}
