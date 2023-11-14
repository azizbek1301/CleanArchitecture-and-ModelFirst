using Demo.Domain.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace Demo.Application.DataAccess
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            :base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
