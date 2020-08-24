using System;
using System.Threading.Tasks;
using ozhakh.application.DTO;

namespace ozhakh.application.Services
{
    public interface IRefreshTokenService
    {
        Task<string> CreateAsync(Guid userId);
        Task RevokeAsync(string refreshToken);
        Task<AuthDto> UseAsync(string refreshToken);
    }
}