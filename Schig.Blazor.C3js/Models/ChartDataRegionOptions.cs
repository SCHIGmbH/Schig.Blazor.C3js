using System;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class ChartDataRegionOptions : IEquatable<ChartDataRegionOptions>
    {
        [JsonPropertyName("start")]
        public int Start { get; set; }

        [JsonPropertyName("end")]
        public int End { get; set; }

        [JsonPropertyName("style")]
        public string Style { get; set; } = "dahsed";

        [JsonPropertyName("label")]
        public string Label { get; set; } = string.Empty;

        [JsonPropertyName("paddingX")]
        public int PaddingX { get; set; } = 0;

        [JsonPropertyName("paddingY")]
        public int PaddingY { get; set; } = 0;

        [JsonPropertyName("vertical")]
        public bool IsVertical { get; set; } = false;

        public override bool Equals(object obj)
        {
            return Equals(obj as ChartDataRegionOptions);
        }

        public bool Equals(ChartDataRegionOptions other)
        {
            return other != null &&
                   Start == other.Start &&
                   End == other.End &&
                   Style == other.Style &&
                   Label == other.Label &&
                   PaddingX == other.PaddingX &&
                   PaddingY == other.PaddingY &&
                   IsVertical == other.IsVertical;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Start, End, Style, Label, PaddingX, PaddingY, IsVertical);
        }
    }
}
