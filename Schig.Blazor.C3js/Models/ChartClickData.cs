using System;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public sealed class ChartClickData : IEquatable<ChartClickData>
    {
        [JsonIgnore]
        public string ChartId { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("index")]
        public int Index { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("value")]
        public int Value { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ChartClickData);
        }

        public bool Equals(ChartClickData other)
        {
            return other != null &&
                   ChartId == other.ChartId &&
                   Id == other.Id &&
                   Index == other.Index &&
                   Name == other.Name &&
                   Value == other.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ChartId, Id, Index, Name, Value);
        }
    }
}
