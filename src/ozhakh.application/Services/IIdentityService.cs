using System;
using System.Threading.Tasks;
using ozhakh.application.Commands;
using ozhakh.application.DTO;

namespace ozhakh.application.Services
{
    public interface IIdentityService
    {
        Task<UserDto> GetAsync(Guid id);
        Task<AuthDto> SignInAsync(SignIn command);
        Task SignUpAsync(SignUp command);
    }
}