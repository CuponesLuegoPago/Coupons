using Coupons.Models;
using Coupons.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Coupons.Controllers.UserRols
{
    [ApiController]
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
        public IActionResult CreateUserRol(UserRol userRol)
        {
            try
            {
                _userRolRepository.addUserRol(userRol);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest (e.Message);
            }
        }
    }
}