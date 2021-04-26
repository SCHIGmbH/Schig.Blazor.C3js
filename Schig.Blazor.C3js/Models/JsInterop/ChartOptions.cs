using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models.JsInterop
{
    public sealed class ChartOptions : IEquatable<ChartOptions>
    {
        [JsonPropertyName("bindto")]
        public ElementReference BindTo { get; private set; }

        [JsonPropertyName("data")]
        public ChartData Data { get; set; }

        [JsonPropertyName("axis")]
        public ChartAxis Axis { get; set; } = null;

        [JsonPropertyName("size")]
        public SizeOptions Size { get; set; } = null;

        [JsonPropertyName("padding")]
        public PaddingOptions Padding { get; set; } = null;

        [JsonPropertyName("color")]
        public ColorOptions Color { get; set; } = null;

        [JsonPropertyName("interaction")]
        public InteractionOptions Interaction { get; set; } = null;

        [JsonPropertyName("transition")]
        public TransitionOptions Transition { get; set; } = null;

        [JsonPropertyName("subchart")]
        public SubchartOptions Subchart { get; set; } = null;

        [JsonPropertyName("zoom")]
        public ZoomOptions Zoom { get; set; } = null;


        private ChartOptions(ElementReference bindTo)
        {
            BindTo = bindTo;
        }

        public ChartOptions(ElementReference bindTo, ChartConfiguration configuration) : this(bindTo)
        {
            configuration.Data ??= new();

            if (configuration.Data.Columns == null
                && configuration.Data.Rows == null
                && configuration.Data.DataObjects == null)
            {
                configuration.Data.Columns = Array.Empty<ColumnsCollection>();
            }

            Data = configuration.Data;
            Axis = configuration.Axis;
            Size = configuration.Size;
            Padding = configuration.Padding;
            Color = configuration.Color;
            Interaction = configuration.Interaction;
            Transition = configuration.Transition;
            Subchart = configuration.Subchart;
            Zoom = configuration.Zoom;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ChartOptions);
        }

        public bool Equals(ChartOptions other)
        {
            return other != null &&
                   EqualityComparer<ElementReference>.Default.Equals(BindTo, other.BindTo) &&
                   EqualityComparer<ChartData>.Default.Equals(Data, other.Data) &&
                   EqualityComparer<ChartAxis>.Default.Equals(Axis, other.Axis) &&
                   EqualityComparer<SizeOptions>.Default.Equals(Size, other.Size) &&
                   EqualityComparer<PaddingOptions>.Default.Equals(Padding, other.Padding) &&
                   EqualityComparer<ColorOptions>.Default.Equals(Color, other.Color) &&
                   EqualityComparer<InteractionOptions>.Default.Equals(Interaction, other.Interaction) &&
                   EqualityComparer<TransitionOptions>.Default.Equals(Transition, other.Transition) &&
                   EqualityComparer<SubchartOptions>.Default.Equals(Subchart, other.Subchart) &&
                   EqualityComparer<ZoomOptions>.Default.Equals(Zoom, other.Zoom);
        }

        public override int GetHashCode()
        {
            HashCode hash = new();
            hash.Add(BindTo);
            hash.Add(Data);
            hash.Add(Axis);
            hash.Add(Size);
            hash.Add(Padding);
            hash.Add(Color);
            hash.Add(Interaction);
            hash.Add(Transition);
            hash.Add(Subchart);
            hash.Add(Zoom);
            return hash.ToHashCode();
        }
    }
}
