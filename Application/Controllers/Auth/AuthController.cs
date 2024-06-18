using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Coupons.Dtos.Auth;
using Coupons.Infrastructure.Contexts;
using System.Text;
using Coupons.Models;

namespace Coupons.Application.Controllers.Auth
{
    public class AuthController : ControllerBase
    {
        private readonly CouponsContext _context;
        public AuthController(CouponsContext context)
        {
            _context = context;
        }

        /* [HttpPost]
        [Route("api/auth/login")]
        public async Task<IActionResult> Get([FromBody] AuthResponse authResponse)
        {
            var userAuth = _context.Pruebas.FirstOrDefault(u => u.Email == authResponse.Email && u.Password == authResponse.Password);

            if (userAuth == null)
            {
                return Unauthorized("The user does not have permission to login, verify your password and try again");
            }
            else
            {
                var SecretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("3C7A6C4E2754B9A31F225E201C02D82E"));
                var signinCredentials = new SigningCredentials(SecretKey, SecurityAlgorithms.HmacSha256);
                //issuer: "";
            }
        } */
    }
}