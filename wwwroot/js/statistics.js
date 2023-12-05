// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var options = {
    series: [{
        data: [400, 430, 448, 470, 540, 580, 690, 1100, 1200, 1380]
    }],
    chart: {
        type: 'bar',
        height: 350

    },
    plotOptions: {
        bar: {
            borderRadius: 4,
            horizontal: true,
        }
    },
    dataLabels: {
        enabled: false
    },
    xaxis: {
        categories: ['borç', 'ev masrafları', 'market', 'alış-veriş', 'faturalar', 'eğlence'],
    }

};

var chart = new ApexCharts(document.querySelector("#chart"), options);
chart.render();



var options = {
    series: [{
        name: 'Gelir',
        data: [44, 55, 57, 56, 61, 58, 63, 60, 66]
    }, {
        name: 'Gider',
        data: [76, 85, 101, 98, 87, 105, 91, 114, 94]
    },],


    chart: {
        type: 'bar',
        height: 350
    },


    plotOptions: {
        bar: {
            horizontal: false,
            columnWidth: '55%',
            endingShape: 'rounded'
        },
    },
    dataLabels: {
        enabled: false
    },
    stroke: {
        show: true,
        width: 2,
        colors: ['black']
    },
    xaxis: {
        categories: ['Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct'],
    },

    fill: {
        opacity: 1
    },
    tooltip: {
        
        y: {
            formatter: function (val) {
                return "$ " + val + " thousands"
            }
            
        }


    }

};

var chart = new ApexCharts(document.querySelector("#bar-chart"), options);
chart.render();


var options = {
    series: [25, 15, 44, 55, 41, 17],
    chart: {
        width: '100%',
        type: 'pie',
    },
    labels: ['Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct'],
    theme: {
        monochrome: {
            enabled: true

        }
    },
    plotOptions: {
        pie: {
            dataLabels: {
                offset: -5
            }
        }
    },
    title: {
        text: ""
    },
    dataLabels: {
        formatter(val, opts) {
            const name = opts.w.globals.labels[opts.seriesIndex]
            return [name, val.toFixed(1) + '%']
        }
    },
    legend: {
        show: false
    }
};

var chart = new ApexCharts(document.querySelector("#pie-chart"), options);
chart.render();

