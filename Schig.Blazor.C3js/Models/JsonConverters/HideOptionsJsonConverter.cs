using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models.JsonConverters
{
    public class HideOptionsJsonConverter : JsonConverter<HideOptions>
    {
        public override HideOptions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, HideOptions value, JsonSerializerOptions options)
        {
            if(value.IsHidden)
            {
                writer.WriteBooleanValue(true);
            }
            else if(value.HiddenDataKeys is not null 
                && value.HiddenDataKeys.Length > 0)
            {
                writer.WriteStartArray();
                for (int i = 0; i < value.HiddenDataKeys.Length; i++)
                {
                    writer.WriteStringValue(value.HiddenDataKeys[i]);
                }
                writer.WriteEndArray();
            }
            else
            {
                writer.WriteBooleanValue(false);
            }
        }
    }
}
