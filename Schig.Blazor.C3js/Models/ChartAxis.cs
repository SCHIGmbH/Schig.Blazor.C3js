using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public sealed class ChartAxis : IEquatable<ChartAxis>
    {
        [JsonPropertyName("rotated")]
        public bool IsRotated { get; set; } = false;

        [JsonPropertyName("x")]
        public XAxisOptions X { get; set; } = null;

        [JsonPropertyName("y")]
        public YAxisOptions Y { get; set; } = null;

        [JsonPropertyName("y2")]
        public YAxisOptions Y2 { get; set; } = null;

        public override bool Equals(object obj)
        {
            return Equals(obj as ChartAxis);
        }

        public bool Equals(ChartAxis other)
        {
            return other != null &&
                   IsRotated == other.IsRotated &&
                   EqualityComparer<XAxisOptions>.Default.Equals(X, other.X) &&
                   EqualityComparer<YAxisOptions>.Default.Equals(Y, other.Y) &&
                   EqualityComparer<YAxisOptions>.Default.Equals(Y2, other.Y2);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IsRotated, X, Y, Y2);
        }
    }
}
