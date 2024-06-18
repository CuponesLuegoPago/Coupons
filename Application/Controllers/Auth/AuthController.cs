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

        [HttpPost]
        [Route("    ")]
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
                var tokenConfigure = new JwtSecurityToken(
                issuer: "http://localhost:5044",
                audience : "http://localhost:5044",
                claims : new List<Claim>(),
                expires : DateTime.Now.AddHours(1),
                signingCredentials : signinCredentials
                );
                var tokenWrite = new JwtSecurityTokenHandler().WriteToken(tokenConfigure);

                return Ok(new
                {
                    token = tokenWrite
                });

                return Unauthorized();

            }
        }
    }
}