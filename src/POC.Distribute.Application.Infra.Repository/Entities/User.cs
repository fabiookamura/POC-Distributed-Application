using Dapper.Contrib.Extensions;

namespace POC.Distribute.Application.Infra.Repository.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public static implicit operator User(Business.Domain.Entities.User user)
        {
            if (user is null)
                return null;

            return new User()
            {
                UserId = user.UserId,
                Nome = user.Nome,
                Email = user.Email
            };
        }
    }
}
