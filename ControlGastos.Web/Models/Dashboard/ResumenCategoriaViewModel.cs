namespace ControlGastos.Web.Models.Dashboard
{
    public class ResumenCategoriaViewModel
    {
        public int CategoriaId { get; set; }

        public string Categoria { get; set; } = string.Empty;

        public decimal Total { get; set; }
    }
}
