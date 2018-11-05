/*=========================================================================================
    File Name: line.js
    Description: Chartjs simple line chart
    ----------------------------------------------------------------------------------------
    Item Name: Robust - Responsive Admin Theme
    Version: 1.2
    Author: PIXINVENT
    Author URL: http://www.themeforest.net/user/pixinvent
==========================================================================================*/

// Line chart
// ------------------------------
$(window).on("load", function(){

    //Get the context of the Chart canvas element we want to select
    var ctx = $("#line-chart");

    // Chart Options
    var chartOptions = {
        responsive: true,
        maintainAspectRatio: false,
        legend: {
            position: 'bottom',
        },
        hover: {
            mode: 'label'
        },
        scales: {
            xAxes: [{
                display: true,
                gridLines: {
                    color: "#f3f3f3",
                    drawTicks: false,
                },
                scaleLabel: {
                    display: true,
                    labelString: 'Dia'
                }
            }],
            yAxes: [{
                display: true,
                gridLines: {
                    color: "#f3f3f3",
                    drawTicks: false,
                },
                scaleLabel: {
                    display: true,
                    labelString: 'Cantidad'
                }
            }]
        },
        title: {
            display: true,
            text: 'Listado'
        }
    };

    // Chart Data
    var chartData = {
        labels: ["Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"],
        datasets: [{
            label: "Producto 1",
            data: [50, 45, 45, 20, 19, 15, 11],
            lineTension: 0,
            fill: false,
            //borderDash: [5, 5],
            borderColor: "#FF5722",
            pointBorderColor: "#FF5722",
            pointBackgroundColor: "#FFF",
            pointBorderWidth: 2,
            pointHoverBorderWidth: 2,
            pointRadius: 4,
                    },
                   {
            label: "Producto 2",
            data: [80, 65, 50, 44, 39, 18, 5],
            lineTension: 0,
            fill: false,
            //borderDash: [5, 5],
            borderColor: "#037808",
            pointBorderColor: "#037808",
            pointBackgroundColor: "#FFF",
            pointBorderWidth: 2,
            pointHoverBorderWidth: 2,
            pointRadius: 4,
                    },
                   {
            label: "Producto 3",
            data: [55, 55, 16, 15, 15, 6, 2],
            lineTension: 0,
            fill: false,
            //borderDash: [5, 5],
            borderColor: "#5529e1",
            pointBorderColor: "#5529e1",
            pointBackgroundColor: "#FFF",
            pointBorderWidth: 2,
            pointHoverBorderWidth: 2,
            pointRadius: 4,
                    },
                   {
            label: "Producto 4",
            data: [78, 77, 55, 51, 46, 28, 20],
            lineTension: 0,
            fill: false,
            //borderDash: [5, 5],
            borderColor: "#b10026",
            pointBorderColor: "#b10026",
            pointBackgroundColor: "#FFF",
            pointBorderWidth: 2,
            pointHoverBorderWidth: 2,
            pointRadius: 4,
                    },
                   {
            label: "Producto 5",
            data: [96, 56, 50, 48, 38, 36, 20],
            lineTension: 0,
            fill: false,
            //borderDash: [5, 5],
            borderColor: "#0600ff",
            pointBorderColor: "#0600ff",
            pointBackgroundColor: "#FFF",
            pointBorderWidth: 2,
            pointHoverBorderWidth: 2,
            pointRadius: 4,
                    },
                  
                ]
    };

    var config = {
        type: 'line',

        // Chart Options
        options : chartOptions,

        data : chartData
    };

    // Create the chart
    var lineChart = new Chart(ctx, config);
});