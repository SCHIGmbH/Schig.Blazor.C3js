using System;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class SizeOptions : IEquatable<SizeOptions>
    {
        [JsonPropertyName("width")]
        public int? Width { get; set; } = null;

        [JsonPropertyName("height")]
        public int? Height { get; set; } = null;

        public override bool Equals(object obj)
        {
            return Equals(obj as SizeOptions);
        }

        public bool Equals(SizeOptions other)
        {
            return other != null &&
                   Width == other.Width &&
                   Height == other.Height;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Width, Height);
        }
    }
}
