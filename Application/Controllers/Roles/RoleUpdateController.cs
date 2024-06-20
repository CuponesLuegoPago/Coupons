using Coupons.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Coupons.Models;

namespace Coupons.Controllers.Roles
{
    public class RoleUpdateController : ControllerBase
    {
        private readonly IRole _roleRepository;

        public RoleUpdateController(IRole roleRepository)
        {
            _roleRepository = roleRepository;
        }

        //Actualizar Rol
        [HttpPut]
        [Route("api/Roles/{id}")]
        public IActionResult UpdateRole([FromBody] Role role, int Id)
        {
            var updatedRole = _roleRepository.UpdateRole(role, Id);
            return Ok(updatedRole);
        }
    }
}