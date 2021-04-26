using System;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class PaddingOptions : IEquatable<PaddingOptions>
    {
        [JsonPropertyName("top")]
        public int? Top { get; set; } = null;

        [JsonPropertyName("right")]
        public int? Right { get; set; } = null;

        [JsonPropertyName("bottom")]
        public int? Bottom { get; set; } = null;

        [JsonPropertyName("left")]
        public int? Left { get; set; } = null;

        public override bool Equals(object obj)
        {
            return Equals(obj as PaddingOptions);
        }

        public bool Equals(PaddingOptions other)
        {
            return other != null &&
                   Top == other.Top &&
                   Right == other.Right &&
                   Bottom == other.Bottom &&
                   Left == other.Left;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Top, Right, Bottom, Left);
        }
    }
}