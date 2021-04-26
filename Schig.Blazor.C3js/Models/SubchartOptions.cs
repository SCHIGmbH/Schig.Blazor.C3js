using System;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class SubchartOptions : IEquatable<SubchartOptions>
    {
        [JsonPropertyName("show")]
        public bool Show { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as SubchartOptions);
        }

        public bool Equals(SubchartOptions other)
        {
            return other != null &&
                   Show == other.Show;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Show);
        }
    }
}
