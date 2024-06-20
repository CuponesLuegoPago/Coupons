using Coupons.Models;
using Coupons.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Coupons.Dtos;

namespace Coupons.Controllers.UserRols
{
    [ApiController]
    public class UserRolUpdateController : ControllerBase
    {
        private readonly IUserRole _userRolRepository;

        public UserRolUpdateController(IUserRole userRolRepository)
        {
            _userRolRepository = userRolRepository;
        }

        //Actualizar el rol de usuario
        [HttpPut]
        [Route("api/userrols/{id}")]
        public IActionResult UpdateUserRol(int id, [FromBody] UserRolDto userRol)
        {
            try
            {
                
                return Ok(_userRolRepository.UpdateUserRol(userRol, id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}