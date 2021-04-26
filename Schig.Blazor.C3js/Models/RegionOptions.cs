using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class RegionOptions
    {
        [JsonPropertyName("axis")]
        public string Axis { get; set; } = null;

        [JsonPropertyName("start")]
        public decimal Start { get; set; }

        [JsonPropertyName("end")]
        public decimal End { get; set; }
    }
}
