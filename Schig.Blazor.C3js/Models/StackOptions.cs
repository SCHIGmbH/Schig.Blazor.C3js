using System;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class StackOptions : IEquatable<StackOptions>
    {
        [JsonPropertyName("normalize")]
        public bool IsNormalize { get; set; } = true;

        public override bool Equals(object obj)
        {
            return Equals(obj as StackOptions);
        }

        public bool Equals(StackOptions other)
        {
            return other != null &&
                   IsNormalize == other.IsNormalize;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IsNormalize);
        }
    }
}