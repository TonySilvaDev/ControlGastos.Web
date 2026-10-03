using ControlGastos.Web.Models.Auth;

namespace ControlGastos.Web.Services.Interfaces
{
    public interface IAuthApiService
    {
        Task<AuthResponse?> LoginAsync(LoginViewModel model, CancellationToken cancellationToken = default);
    }
}
