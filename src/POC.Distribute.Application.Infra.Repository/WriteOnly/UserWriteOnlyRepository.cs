using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using POC.Distribute.Application.Business.Domain.Interfaces;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Infra.Repository.WriteOnly
{
    public class UserWriteOnlyRepository : IUserRepository
    {
        private readonly IConfiguration _configuration;
        public UserWriteOnlyRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<int> InsertUserAsync(Business.Domain.Entities.User user)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("sql"));
            Entities.UserWriteOnly userPersistence = user;
            return await connection.InsertAsync(userPersistence);
        }

        public async Task<bool> UpdateUserAsync(Business.Domain.Entities.User user)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("sql"));
            Entities.UserWriteOnly userPersistence = user;
            return await connection.UpdateAsync(userPersistence);
        }

        public async Task<bool> DeleteUserAsync(Business.Domain.Entities.User user)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("sql"));
            Entities.UserWriteOnly userPersistence = user;
            return await connection.DeleteAsync(userPersistence);
        }
    }
}
