using System.ComponentModel.DataAnnotations;

namespace Demo.Domain.DTOs.UserDTOs
{
    public class UserDto
    {
        [Required]
        public string? Name { get; set; }
        public string? Email { get; set; }
        [Required]
        public string Password { get; set; }
        public int Age { get; set; }
    }
}
