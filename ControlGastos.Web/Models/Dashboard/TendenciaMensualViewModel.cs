namespace ControlGastos.Web.Models.Dashboard
{
    public class TendenciaMensualViewModel
    {
        public int Anio { get; set; }

        public int Mes { get; set; }

        public string NombreMes { get; set; } = string.Empty;

        public decimal Ingresos { get; set; }

        public decimal Gastos { get; set; }
    }
}
