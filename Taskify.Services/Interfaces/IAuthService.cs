using BrainHope.Services.DTO.Authentication.SingUp;
using Taskify.DataAccess.Models;
using Taskify.Services.DTOs.Responses;

namespace Taskify.Services.Interfaces
{
    public interface IAuthService
    {
        Task<ApiResponse<TokenType>> RegisterUserAsync(RegisterUser registerUser);

        Task<ApiResponse<LoginResponse>> GetJwtTokenAsync(ApplicationUser user);
    }
}
