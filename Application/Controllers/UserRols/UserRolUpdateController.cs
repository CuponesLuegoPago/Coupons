using Coupons.Models;
using Coupons.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Coupons.Controllers.UserRols
{
    [ApiController]
    public class UserRolUpdateController
    {
        private readonly IUserRole _userRolRepository;

        public UserRolUpdateController(IUserRole userRolRepository)
        {
            _userRolRepository = userRolRepository;
        }

        //Actualizar el rol de usuario
        /* [HttpPut]
        [Route("api/UserRol{id}")] */
    }
}