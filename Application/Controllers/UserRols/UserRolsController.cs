using Coupons.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Coupons.Models;

namespace Coupons.Controllers.UserRols
{
    public class UserRolsController : ControllerBase
    {
        private readonly IUserRole _userRolsRepository;

        public UserRolsController(IUserRole userRolsRepository)
        {
            _userRolsRepository = userRolsRepository;
        }
        // Obtener todos los roles de usuario
        [HttpGet]
        [Route("api/userRols")]
        public IActionResult GetAllUserRols()
        {
            try
            {
                return Ok(_userRolsRepository.GetUserRols());  
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        // Obtener todos los roles de usuario por Id
        [HttpGet]
        [Route("api/userRols/{id}")]
        public IActionResult GetUserRolById(int id)
        {
            try 
            {
                return Ok(_userRolsRepository.GetRol(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}