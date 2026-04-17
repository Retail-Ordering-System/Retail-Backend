using Retail_backend.DTOs.Auth;
using Retail_backend.Services.Interfaces;

namespace Retail_backend.Services
{
    public class AuthService : IAuthService
    {
        Task<AuthResponseDto> IAuthService.LoginAsync(LoginDto dto)
        {
            throw new NotImplementedException();
        }

        Task<AuthResponseDto> IAuthService.RegisterAsync(RegisterDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
