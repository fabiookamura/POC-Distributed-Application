using System.Threading.Tasks;
using POC.Distribute.Application.Business.Domain.Entities;

namespace POC.Distribute.Application.Business.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> DeleteUserAsync(User user);
        Task<int> InsertUserAsync(User user);
        Task<bool> UpdateUserAsync(User user);
    }
}
