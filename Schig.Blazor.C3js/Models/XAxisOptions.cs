using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class XAxisOptions : IEquatable<XAxisOptions>
    {
        [JsonPropertyName("show")]
        public bool Show { get; set; } = true;

        [JsonPropertyName("type")]
        public string Type { get; set; } = "indexed";

        [JsonPropertyName("localtime")]
        public bool IsLocaltime { get; set; } = true;

        [JsonPropertyName("categories")]
        public string[] Categories { get; set; } = Array.Empty<string>();

        [JsonPropertyName("tick")]
        public XTickOptions Tick { get; set; } = null;

        [JsonPropertyName("max")]
        public int? Max { get; set; } = null;

        [JsonPropertyName("min")]
        public int? Min { get; set; } = null;

        [JsonPropertyName("padding")]
        public PaddingOptions Padding { get; set; } = null;

        [JsonPropertyName("height")]
        public int? Height { get; set; } = null;

        [JsonPropertyName("extent")]
        public int[] Extent { get; set; } = null;

        [JsonPropertyName("label")]
        public AxisLabel Label { get; set; } = null;

        public override bool Equals(object obj)
        {
            return Equals(obj as XAxisOptions);
        }

        public bool Equals(XAxisOptions other)
        {
            return other != null &&
                   Show == other.Show &&
                   Type == other.Type &&
                   IsLocaltime == other.IsLocaltime &&
                   EqualityComparer<string[]>.Default.Equals(Categories, other.Categories) &&
                   EqualityComparer<XTickOptions>.Default.Equals(Tick, other.Tick) &&
                   Max == other.Max &&
                   Min == other.Min &&
                   EqualityComparer<PaddingOptions>.Default.Equals(Padding, other.Padding) &&
                   Height == other.Height &&
                   EqualityComparer<int[]>.Default.Equals(Extent, other.Extent) &&
                   EqualityComparer<AxisLabel>.Default.Equals(Label, other.Label);
        }

        public override int GetHashCode()
        {
            HashCode hash = new();
            hash.Add(Show);
            hash.Add(Type);
            hash.Add(IsLocaltime);
            hash.Add(Categories);
            hash.Add(Tick);
            hash.Add(Max);
            hash.Add(Min);
            hash.Add(Padding);
            hash.Add(Height);
            hash.Add(Extent);
            hash.Add(Label);
            return hash.ToHashCode();
        }
    }
}
