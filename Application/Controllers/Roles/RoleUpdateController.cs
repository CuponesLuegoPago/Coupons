using Coupons.Models;
using Coupons.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Coupons.Controllers.Roles
{
    [ApiController]
    public class RoleUpdateController
    {
        private readonly IRole _roleRepository;

        public RoleUpdateController(IRole roleRepository)
        {
            _roleRepository = roleRepository;
        }

        //Actualizar Rol
        /* [HttpPut]
        [Route("api/role{id}")] */
    }
}