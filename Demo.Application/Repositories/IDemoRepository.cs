using Demo.Domain.Models;

namespace Demo.Application.Repositories
{
    public interface IDemoRepository
    {
        public ValueTask<IEnumerable<User>> GetAllUsersAsync();
    }
}
