using System;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class TransitionOptions : IEquatable<TransitionOptions>
    {
        [JsonPropertyName("duration")]
        public int Duration { get; set; } = 350;

        public override bool Equals(object obj)
        {
            return Equals(obj as TransitionOptions);
        }

        public bool Equals(TransitionOptions other)
        {
            return other != null &&
                   Duration == other.Duration;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Duration);
        }
    }
}
