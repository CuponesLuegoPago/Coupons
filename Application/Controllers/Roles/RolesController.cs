using Coupons.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Coupons.Models;

namespace Coupons.Controllers.Roles
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase
    {
        private readonly IRole _rolesRepository;

        public RolesController(IRole rolesRepository)
        {
            _rolesRepository = rolesRepository;
        }
        // Obtener todos los roles
        [HttpGet]
        [Route("api/Roles")]
        public IActionResult GetAllRoles()
        {
            try
            {
                return Ok(_rolesRepository.GetRoles());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        // Obtener todos los roles por id
        [HttpGet]
        [Route("api/Roles/{id}")]
        public IActionResult GetRoleById(int id)
        {
            try
            {
                return Ok(_rolesRepository.GetRole(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}