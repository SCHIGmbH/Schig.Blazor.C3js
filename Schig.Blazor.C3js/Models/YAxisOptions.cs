using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class YAxisOptions : IEquatable<YAxisOptions>
    {
        [JsonPropertyName("show")]
        public bool Show { get; set; } = true;

        [JsonPropertyName("inner")]
        public bool IsInner { get; set; } = false;

        /// <summary>
        /// Scale type for Y axis.
        /// Possible values: linear, timeseries, log
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = "linear";

        [JsonPropertyName("max")]
        public int? Max { get; set; } = null;

        [JsonPropertyName("min")]
        public int? Min { get; set; } = null;

        [JsonPropertyName("inverted")]
        public bool IsInverted { get; set; } = false;

        [JsonPropertyName("center")]
        public int? Center { get; set; } = null;

        [JsonPropertyName("label")]
        public AxisLabel Label { get; set; } = null;

        [JsonPropertyName("tick")]
        public YTickOptions Tick { get; set; } = null;

        [JsonPropertyName("padding")]
        public PaddingOptions Padding { get; set; } = null;

        [JsonPropertyName("default")]
        public int[] Default { get; set; } = null;

        public override bool Equals(object obj)
        {
            return Equals(obj as YAxisOptions);
        }

        public bool Equals(YAxisOptions other)
        {
            return other != null &&
                   Show == other.Show &&
                   IsInner == other.IsInner &&
                   Type == other.Type &&
                   Max == other.Max &&
                   Min == other.Min &&
                   IsInverted == other.IsInverted &&
                   Center == other.Center &&
                   EqualityComparer<AxisLabel>.Default.Equals(Label, other.Label) &&
                   EqualityComparer<YTickOptions>.Default.Equals(Tick, other.Tick) &&
                   EqualityComparer<PaddingOptions>.Default.Equals(Padding, other.Padding) &&
                   EqualityComparer<int[]>.Default.Equals(Default, other.Default);
        }

        public override int GetHashCode()
        {
            HashCode hash = new();
            hash.Add(Show);
            hash.Add(IsInner);
            hash.Add(Type);
            hash.Add(Max);
            hash.Add(Min);
            hash.Add(IsInverted);
            hash.Add(Center);
            hash.Add(Label);
            hash.Add(Tick);
            hash.Add(Padding);
            hash.Add(Default);
            return hash.ToHashCode();
        }
    }
}
