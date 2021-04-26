using Schig.Blazor.C3js.Models;
using System;
using System.Collections.Generic;

namespace Schig.Blazor.C3js
{
    public class ChartConfiguration : IEquatable<ChartConfiguration>
    {
        public ChartData Data { get; set; }
        public ChartAxis Axis { get; set; }
        public SizeOptions Size { get; set; }
        public PaddingOptions Padding { get; set; }
        public ColorOptions Color { get; set; }
        public InteractionOptions Interaction { get; set; }
        public TransitionOptions Transition { get; set; }
        public SubchartOptions Subchart { get; set; }
        public ZoomOptions Zoom { get; set; }

        public ChartConfiguration(ChartData data,
            ChartAxis axis = null,
            SizeOptions size = null,
            PaddingOptions padding = null,
            ColorOptions color = null,
            InteractionOptions interaction = null,
            TransitionOptions transition = null,
            SubchartOptions subchart = null,
            ZoomOptions zoom = null)
        {
            Data = data;
            Axis = axis;
            Size = size;
            Padding = padding;
            Color = color;
            Interaction = interaction;
            Transition = transition;
            Subchart = subchart;
            Zoom = zoom;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ChartConfiguration);
        }

        public bool Equals(ChartConfiguration other)
        {
            return other != null &&
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
