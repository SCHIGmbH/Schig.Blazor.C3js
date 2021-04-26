var charts = new Map();

window.generateChart = (chartOptons, chartClickHelper) => {
    chartOptons = prepareChartConfiguration(chartOptons);
    chartOptons.data.onclick = function (d, element) {
        chartClickHelper.invokeMethodAsync('onChartClickHandler', new ChartClickData(d.index, d.id, d.name, d.value));
        //DotNet.invokeMethodAsync('Blazor.C3js', 'onChartClickHandler', new ChartClickData(d.index, d.id, d.name, d.value));
    };

    charts.set(chartOptons.bindto.id, c3.generate(chartOptons));
}

function prepareChartConfiguration(chartOptons) {
    var bindto = chartOptons.bindto;
    delete chartOptons.bindto;
    var cleanedchartOptons = removeNullValuedParameters(chartOptons);
    cleanedchartOptons.bindto = bindto;
    return cleanedchartOptons;
}

function removeNullValuedParameters (object) {
    // Source: https://stackoverflow.com/a/57625661 - Thanks to: https://stackoverflow.com/users/1602301/chickens (chickens)
    if (Array.isArray(object)) {
        return object
            .map(v => (v && typeof v === 'object') ? removeNullValuedParameters(v) : v)
            .filter(v => !(v == null));
    } else {
        return Object.entries(object)
            .map(([k, v]) => [k, v && typeof v === 'object' ? removeNullValuedParameters(v) : v])
            .reduce((a, [k, v]) => (v == null ? a : (a[k] = v, a)), {});
    }
}

class ChartClickData {
    constructor(index, id, name, value) {
        this.index = index;
        this.id = id;
        this.name = name;
        this.value = value;
    }
}