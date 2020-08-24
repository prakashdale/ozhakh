using System.Threading.Tasks;
using Convey.CQRS.Commands;
using ozhakh.application.Services;

namespace ozhakh.application.Commands.Handlers
{
    // Simple wrapper
    internal sealed  class SignUpHandler : ICommandHandler<SignUp>
    {
        private readonly IIdentityService _identityService;

        public SignUpHandler(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public Task HandleAsync(SignUp command) => _identityService.SignUpAsync(command);
    }
}