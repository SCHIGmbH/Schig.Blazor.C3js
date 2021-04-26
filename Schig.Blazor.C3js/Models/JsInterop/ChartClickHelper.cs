using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Schig.Blazor.C3js.Models.JsInterop
{
    public class ChartClickHelper
    {
        private readonly EventCallback<ChartClickData> notifyChartClicked;
        private readonly string chartId;

        public ChartClickHelper(EventCallback<ChartClickData> notifyChartClicked, string ChartId)
        {
            chartId = ChartId;
            this.notifyChartClicked = notifyChartClicked;
        }

        [JSInvokable("onChartClickHandler")]
        public Task OnChartClickHandlerAsync(ChartClickData data)
        {
            data.ChartId = chartId;
            return notifyChartClicked.InvokeAsync(data);
        }
    }
}
