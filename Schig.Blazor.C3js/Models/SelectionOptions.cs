using System;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class SelectionOptions : IEquatable<SelectionOptions>
    {
        [JsonPropertyName("enabled")]
        public bool IsEnabled { get; set; } = false;

        [JsonPropertyName("grouped")]
        public bool IsGrouped { get; set; } = false;

        [JsonPropertyName("multiple")]
        public bool IsMultiple { get; set; } = true;

        [JsonPropertyName("draggable")]
        public bool IsDraggable { get; set; } = false;

        public override bool Equals(object obj)
        {
            return Equals(obj as SelectionOptions);
        }

        public bool Equals(SelectionOptions other)
        {
            return other != null &&
                   IsEnabled == other.IsEnabled &&
                   IsGrouped == other.IsGrouped &&
                   IsMultiple == other.IsMultiple &&
                   IsDraggable == other.IsDraggable;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IsEnabled, IsGrouped, IsMultiple, IsDraggable);
        }
    }
}
