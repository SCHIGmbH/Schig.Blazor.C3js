using Schig.Blazor.C3js.Models;
using Schig.Blazor.C3js.Models.JsInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Schig.Blazor.C3js
{
    public partial class C3jsChart : ComponentBase
    {
        private bool shouldRender = true;
        private ChartConfiguration previousChartConfiguration;

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        private ElementReference ChartContainerReference { get; set; }

        public Guid UniqueChartId { get; } = Guid.NewGuid();

        [Parameter]
        public string ChartId { get; set; }

        [Parameter]
        public EventCallback<ChartClickData> OnChartClickCallback { get; set; }

        [Parameter]
        public ChartConfiguration Configuration { get; set; }

        protected override bool ShouldRender() => shouldRender;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            DotNetObjectReference<ChartClickHelper> chartClickHelper = DotNetObjectReference.Create(new ChartClickHelper(OnChartClickCallback, ChartId));

            ChartOptions options = new(ChartContainerReference, Configuration);
            await JSRuntime.InvokeVoidAsync("generateChart", options, chartClickHelper);

            await base.OnAfterRenderAsync(firstRender);
        }

        protected override async Task OnParametersSetAsync()
        {
            // Only rerender if the chart configuration changed
            shouldRender = !EqualityComparer<ChartConfiguration>.Default
                .Equals(Configuration, previousChartConfiguration);

            previousChartConfiguration = Configuration;
            await base.OnParametersSetAsync();
        }
    }
}
