using Schig.Blazor.C3js.Models.JsonConverters;
using System;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    [JsonConverter(typeof(CullingOptionsJsonConverter))]
    public class CullingOptions : IEquatable<CullingOptions>
    {
        public bool IsCulling { get; set; } = true;

        public int Max { get; set; } = 10;

        public override bool Equals(object obj)
        {
            return Equals(obj as CullingOptions);
        }

        public bool Equals(CullingOptions other)
        {
            return other != null &&
                   IsCulling == other.IsCulling &&
                   Max == other.Max;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IsCulling, Max);
        }
    }
}
