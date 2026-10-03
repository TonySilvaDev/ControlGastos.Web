using ControlGastos.Web.Models.Dashboard;
using ControlGastos.Web.Services.Interfaces;
using System.Net;

namespace ControlGastos.Web.Services
{
    public class DashboardApiService : IDashboardApiService
    {
        private readonly HttpClient _httpClient;

        public DashboardApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<DashboardViewModel?> ObtenerDashboardAsync(
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync(
                "api/dashboard",
                cancellationToken);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                return null;
            }

            response.EnsureSuccessStatusCode();

            return await response.Content
                .ReadFromJsonAsync<DashboardViewModel>(
                    cancellationToken: cancellationToken);
        }
    }
}
