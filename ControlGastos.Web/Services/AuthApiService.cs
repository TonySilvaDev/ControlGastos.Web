using ControlGastos.Web.Models.Auth;
using ControlGastos.Web.Services.Interfaces;

namespace ControlGastos.Web.Services
{
    public class AuthApiService : IAuthApiService
    {
        private readonly HttpClient _httpClient;

        public AuthApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ControlGastosApi");
        }

        public async Task<AuthResponse?> LoginAsync(
            LoginViewModel model,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.PostAsJsonAsync(
                "api/Auth/login",
                model,
                cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            return await response.Content
                .ReadFromJsonAsync<AuthResponse>(
                    cancellationToken: cancellationToken);
        }
    }
}
