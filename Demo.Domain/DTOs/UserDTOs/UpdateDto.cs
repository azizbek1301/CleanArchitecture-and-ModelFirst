using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Demo.Domain.DTOs.UserDTOs
{
    public class UpdateDto
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public string? Email { get; set; }
        
        public string Password { get; set; }
        public int Age { get; set; }
    }
}
