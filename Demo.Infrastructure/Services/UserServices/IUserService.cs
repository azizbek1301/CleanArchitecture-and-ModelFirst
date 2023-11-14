using Demo.Domain.Models;

namespace Demo.Infrastructure.Services.UserServices
{
    public interface IUserService
    {
        public ValueTask<IEnumerable<User>> GetAllUsersAsync();
    }
}
