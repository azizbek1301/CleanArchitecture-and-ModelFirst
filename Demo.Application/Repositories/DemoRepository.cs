using Demo.Application.DataAccess;
using Demo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Application.Repositories
{
    public class DemoRepository : IDemoRepository
    {
        public readonly DemoDbContext _dbContext;
        public DemoRepository(DemoDbContext context)
        {
            _dbContext = context;
            
        }
        public async ValueTask<IEnumerable<User>> GetAllUsersAsync()
        {
            IEnumerable<User> users=await _dbContext.Users.ToListAsync();
            return users;
        }
    }
}
