using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class XTickOptions : IEquatable<XTickOptions>
    {
        [JsonPropertyName("centered")]
        public bool IsCentered { get; set; } = false;

        [JsonPropertyName("format")]
        public string Format { get; set; } = null;

        [JsonPropertyName("culling")]
        public CullingOptions Culling { get; set; } = null;

        [JsonPropertyName("count")]
        public int? Count { get; set; } = null;

        [JsonPropertyName("fit")]
        public bool IsFit { get; set; } = true;

        [JsonPropertyName("values")]
        public object[] Values { get; set; } = null;

        [JsonPropertyName("rotate")]
        public int Rotate { get; set; } = 0;

        /// <summary>
        /// Corresponds to "outer"
        /// </summary>
        [JsonPropertyName("outer")]
        public bool IsShowOuter{ get; set; } = true;

        [JsonPropertyName("multiline")]
        public bool IsMultiline { get; set; } = true;

        [JsonPropertyName("multilineMax")]
        public int MultilineMax { get; set; } = 0;

        public override bool Equals(object obj)
        {
            return Equals(obj as XTickOptions);
        }

        public bool Equals(XTickOptions other)
        {
            return other != null &&
                   IsCentered == other.IsCentered &&
                   Format == other.Format &&
                   EqualityComparer<CullingOptions>.Default.Equals(Culling, other.Culling) &&
                   Count == other.Count &&
                   IsFit == other.IsFit &&
                   EqualityComparer<object[]>.Default.Equals(Values, other.Values) &&
                   Rotate == other.Rotate &&
                   IsShowOuter == other.IsShowOuter &&
                   IsMultiline == other.IsMultiline &&
                   MultilineMax == other.MultilineMax;
        }

        public override int GetHashCode()
        {
            HashCode hash = new();
            hash.Add(IsCentered);
            hash.Add(Format);
            hash.Add(Culling);
            hash.Add(Count);
            hash.Add(IsFit);
            hash.Add(Values);
            hash.Add(Rotate);
            hash.Add(IsShowOuter);
            hash.Add(IsMultiline);
            hash.Add(MultilineMax);
            return hash.ToHashCode();
        }
    }
}
