using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class ZoomOptions : IEquatable<ZoomOptions>
    {
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("rescale")]
        public bool Rescale { get; set; }

        [JsonPropertyName("extent")]
        public int[] Extent { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ZoomOptions);
        }

        public bool Equals(ZoomOptions other)
        {
            return other != null &&
                   Enabled == other.Enabled &&
                   Type == other.Type &&
                   Rescale == other.Rescale &&
                   EqualityComparer<int[]>.Default.Equals(Extent, other.Extent);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Enabled, Type, Rescale, Extent);
        }
    }
}
