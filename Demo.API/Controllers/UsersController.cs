using Demo.Domain.DTOs.UserDTOs;
using Demo.Domain.Models.UserModels;
using Demo.Infrastructure.Services.UserServices;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            IEnumerable<User> users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }
        [HttpPost]
        public async ValueTask<IActionResult>CreateUser(UserDto model)
        {
            bool value=await _userService.CreateAsync(model);
            return Ok(value);
        }
    }
}
