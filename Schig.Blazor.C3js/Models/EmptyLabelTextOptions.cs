using Schig.Blazor.C3js.Models.JsonConverters;
using System;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    [JsonConverter(typeof(EmptyLabelTextOptionsJsonConverter))]
    public class EmptyLabelTextOptions : IEquatable<EmptyLabelTextOptions>
    {
        public string Text { get; set; } = string.Empty;

        public override bool Equals(object obj)
        {
            return Equals(obj as EmptyLabelTextOptions);
        }

        public bool Equals(EmptyLabelTextOptions other)
        {
            return other != null &&
                   Text == other.Text;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text);
        }
    }
}
