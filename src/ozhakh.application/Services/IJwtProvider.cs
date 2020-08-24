using System;
using System.Collections.Generic;
using ozhakh.application.DTO;

namespace ozhakh.application.Services
{
    public interface IJwtProvider
    {
        AuthDto Create(Guid userId, string role, string audience = null,
            IDictionary<string, IEnumerable<string>> claims = null);
    }
}