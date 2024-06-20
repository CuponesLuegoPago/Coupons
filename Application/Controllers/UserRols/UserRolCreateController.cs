using Coupons.Models;
using Coupons.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Coupons.Controllers.UserRols
{
    public class UserRolCreateController : ControllerBase
    {
        private readonly IUserRole _userRolRepository;
        
        public UserRolCreateController(IUserRole userRolRepository)
        {
            _userRolRepository = userRolRepository;
        }

        // Crear nuevo Rol de Usuario
        [HttpPost]
        [Route("api/userrols")]
        public IActionResult CreateUserRol([FromBody] UserRol userRol)
        {
            try
            {
                return Ok(_userRolRepository.addUserRol(userRol));
            }
            catch (Exception e)
            {
                return BadRequest (e.Message);
            }
        }
    }
}