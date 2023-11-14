using Demo.Application.DataAccess;
using Demo.Domain.BaseModels.Enums;
using Demo.Domain.DTOs.UserDTOs;
using Demo.Domain.Models.UserModels;
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

        public async ValueTask<bool> CreateAsync(UserDto userDto)
        {
            try
            {
                User user = new User()
                {
                    Name = userDto.Name,
                    Email = userDto.Email,
                    Age = userDto.Age,
                    Password = userDto.Password,
                };
                await _dbContext.Users.AddAsync(user);
                int x=await _dbContext.SaveChangesAsync();
                return x>0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ValueTask<bool> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<IEnumerable<User>> GetAllUsersAsync()
        {
            IEnumerable<User> users=await _dbContext.Users.ToListAsync();
            return users;
        }

        public ValueTask<User> GetByIdAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> UpdateAsync(UpdateDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
