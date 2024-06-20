using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupons.Dtos.Auth
{
    public class AuthResponse
    {
        public string Email {get; set; }
        public string Password {get; set; }
    }
}