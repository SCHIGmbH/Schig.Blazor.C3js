using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class YTickOptions : IEquatable<YTickOptions>
    {
        [JsonPropertyName("outer")]
        public bool? IsOuter { get; set; } = null;

        [JsonPropertyName("values")]
        public int[] Values { get; set; } = null;

        [JsonPropertyName("count")]
        public int? Count{ get; set; } = null;

        public override bool Equals(object obj)
        {
            return Equals(obj as YTickOptions);
        }

        public bool Equals(YTickOptions other)
        {
            return other != null &&
                   IsOuter == other.IsOuter &&
                   EqualityComparer<int[]>.Default.Equals(Values, other.Values) &&
                   Count == other.Count;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IsOuter, Values, Count);
        }
    }
}