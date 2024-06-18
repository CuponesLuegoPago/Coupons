using Coupons.Models;
using Coupons.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Coupons.Controllers.Roles
{
    [ApiController]
    public class RoleCreateController : ControllerBase
    {
        private readonly IRole _roleRepository;

        public RoleCreateController(IRole roleRepository)
        {
            _roleRepository = roleRepository;
        }

        // Crear nuevo Usuario de Marteting
        [HttpPost]
        [Route("api/roles")]
        public IActionResult CreateRole(Role role)
        {
            try
            {
                _roleRepository.AddRole(role);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}