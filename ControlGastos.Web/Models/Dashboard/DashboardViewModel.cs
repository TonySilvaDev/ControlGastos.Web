namespace ControlGastos.Web.Models.Dashboard
{
    public class DashboardViewModel
    {
        public decimal Saldo { get; set; }

        public decimal TotalIngresos { get; set; }

        public decimal TotalGastos { get; set; }

        public List<ResumenCategoriaViewModel> GastosPorCategoria { get; set; }
            = new();

        public List<TendenciaMensualViewModel> TendenciaMensual { get; set; }
            = new();

        public List<TransaccionRecienteViewModel> TransaccionesRecientes { get; set; }
            = new();
    }
}
