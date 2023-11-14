using Demo.Domain.DTOs.UserDTOs;
using Demo.Domain.Models.UserModels;

namespace Demo.Application.Repositories
{
    public interface IDemoRepository
    {
        public ValueTask<IEnumerable<User>> GetAllUsersAsync();
        public ValueTask<User> GetByIdAsync();
        public ValueTask<bool> CreateAsync(UserDto userDto);
        public ValueTask<bool> UpdateAsync(UpdateDto updateDto);
        public ValueTask<bool> DeleteAsync(int Id);
    }
}
