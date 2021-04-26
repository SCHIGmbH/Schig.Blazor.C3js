using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class Keys : IEquatable<Keys>
    {
        [JsonPropertyName("x")]
        public string X { get; set; }

        [JsonPropertyName("value")]
        public string[] Value { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Keys);
        }

        public bool Equals(Keys other)
        {
            return other != null &&
                   X == other.X &&
                   EqualityComparer<string[]>.Default.Equals(Value, other.Value);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Value);
        }
    }
}
