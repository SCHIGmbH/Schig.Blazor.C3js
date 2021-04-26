using System;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class InteractionOptions : IEquatable<InteractionOptions>
    {
        [JsonPropertyName("enabled")]
        public bool IsEnabled { get; set; } = true;

        public override bool Equals(object obj)
        {
            return Equals(obj as InteractionOptions);
        }

        public bool Equals(InteractionOptions other)
        {
            return other != null &&
                   IsEnabled == other.IsEnabled;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IsEnabled);
        }
    }
}
