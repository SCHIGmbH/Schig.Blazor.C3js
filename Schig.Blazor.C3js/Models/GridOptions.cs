using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class GridOptions
    {
        [JsonPropertyName("x")]
        public GridXAxisOptions X { get; set; } = null;
    }
}
