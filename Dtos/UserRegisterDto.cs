using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.Dtos
{
    public class UserRegisterDto
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public RoleType Role { get; set; }
    }
}
