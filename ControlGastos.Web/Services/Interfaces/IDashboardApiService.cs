using ControlGastos.Web.Models.Dashboard;

namespace ControlGastos.Web.Services.Interfaces
{
    public interface IDashboardApiService
    {
        Task<DashboardViewModel?> ObtenerDashboardAsync(
            CancellationToken cancellationToken = default);
    }
}
