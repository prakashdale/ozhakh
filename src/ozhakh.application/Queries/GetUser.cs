using System;
using Convey.CQRS.Queries;
using ozhakh.application.DTO;

namespace ozhakh.application.Queries
{
    public class GetUser : IQuery<UserDto>
    {
        public Guid UserId { get; set; }
    }
}