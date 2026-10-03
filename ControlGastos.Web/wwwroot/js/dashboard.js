const tendenciaMensual = @Html.Raw(
    System.Text.Json.JsonSerializer.Serialize(
        Model.TendenciaMensual
    )
);

const gastosPorCategoria = @Html.Raw(
    System.Text.Json.JsonSerializer.Serialize(
        Model.GastosPorCategoria
    )
);

document.addEventListener("DOMContentLoaded", function () {

    crearGraficoTendencia();
    crearGraficoCategorias();

});


function crearGraficoTendencia() {

    const canvas =
        document.getElementById("monthlyTrendChart");

    if (!canvas) {
        return;
    }

    const labels =
        tendenciaMensual.map(x => x.nombreMes);

    const ingresos =
        tendenciaMensual.map(x => x.ingresos);

    const gastos =
        tendenciaMensual.map(x => x.gastos);


    new Chart(canvas, {

        type: "line",

        data: {

            labels: labels,

            datasets: [

                {
                    label: "Ingresos",
                    data: ingresos,

                    tension: 0.35,

                    borderWidth: 2,

                    fill: false
                },

                {
                    label: "Gastos",
                    data: gastos,

                    tension: 0.35,

                    borderWidth: 2,

                    fill: false
                }

            ]

        },

        options: {

            responsive: true,

            maintainAspectRatio: false,

            plugins: {

                legend: {
                    position: "top"
                }

            },

            scales: {

                y: {

                    beginAtZero: true,

                    ticks: {

                        callback: function (value) {

                            return new Intl.NumberFormat(
                                "es-MX",
                                {
                                    style: "currency",
                                    currency: "MXN"
                                }
                            ).format(value);

                        }

                    }

                }

            }

        }

    });
}


function crearGraficoCategorias() {

    const canvas =
        document.getElementById("expensesCategoryChart");

    if (!canvas) {
        return;
    }


    const labels =
        gastosPorCategoria.map(x => x.categoria);

    const valores =
        gastosPorCategoria.map(x => x.total);


    new Chart(canvas, {

        type: "doughnut",

        data: {

            labels: labels,

            datasets: [

                {
                    data: valores,

                    borderWidth: 2
                }

            ]

        },

        options: {

            responsive: true,

            maintainAspectRatio: false,

            plugins: {

                legend: {
                    position: "bottom"
                }

            }

        }

    });

}