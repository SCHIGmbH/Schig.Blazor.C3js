using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class ColorOptions : IEquatable<ColorOptions>
    {
        [JsonPropertyName("pattern")]
        public string[] Pattern { get; set; } = null;

        public override bool Equals(object obj)
        {
            return Equals(obj as ColorOptions);
        }

        public bool Equals(ColorOptions other)
        {
            return other != null &&
                   EqualityComparer<string[]>.Default.Equals(Pattern, other.Pattern);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Pattern);
        }
    }
}