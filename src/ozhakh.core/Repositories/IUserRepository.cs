using System;
using System.Threading.Tasks;
using ozhakh.core.Entities;

namespace ozhakh.core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetAsync(Guid id);
        Task<User> GetAsync(string email);
        Task AddAsync(User user);
    }
}