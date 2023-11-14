using Demo.Application.Repositories;
using Demo.Domain.DTOs.UserDTOs;
using Demo.Domain.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IDemoRepository _demoRepository;
        public UserService(IDemoRepository demoRepository)
        {
            _demoRepository = demoRepository;
        }

        public async ValueTask<bool> CreateAsync(UserDto userDto)
        {
            try
            {
                bool result= await _demoRepository.CreateAsync(userDto);
                return true;
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
            try
            {
                var users=await _demoRepository.GetAllUsersAsync();
                if(users is not null)
                {
                    return users;
                }
                return Enumerable.Empty<User>();

            }
            catch (Exception ex)
            {
                return Enumerable.Empty<User>();
            }
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
