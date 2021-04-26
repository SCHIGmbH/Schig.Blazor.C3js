using System;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public sealed class AxisLabel : IEquatable<AxisLabel>
    {
        [JsonPropertyName("text")]
        public string Text { get; set; } = "";

        /// <summary>
        /// Position of the label text.
        /// Possible positions are
        /// (when axis is horizontal): inner-right [default], inner-center, inner-left, outer-right, outer-center, outer-left
        /// (when axis is vertical): inner-top [default], inner-middle, inner-bottom, outer-top, outer-middle, outer-bottom
        /// </summary>
        [JsonPropertyName("position")]
        public string Position { get; set; } = null;

        public override bool Equals(object obj)
        {
            return Equals(obj as AxisLabel);
        }

        public bool Equals(AxisLabel other)
        {
            return other != null &&
                   Text == other.Text &&
                   Position == other.Position;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text, Position);
        }
    }
}
