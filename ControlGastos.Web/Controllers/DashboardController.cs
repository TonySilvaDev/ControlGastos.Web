using ControlGastos.Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ControlGastos.Web.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IDashboardApiService _dashboardApiService;

        public DashboardController(
            IDashboardApiService dashboardApiService)
        {
            _dashboardApiService = dashboardApiService;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var dashboard =
                await _dashboardApiService
                    .ObtenerDashboardAsync(cancellationToken);

            if (dashboard == null)
            {
                return RedirectToAction(
                    "Login",
                    "Auth");
            }

            return View(dashboard);
        }
    }
}
