using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Coupons.Application.Controllers.MarketPlaceUser
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarketPlaceUserDeleteController(IMarketPlaceUsers marketPlaceUsers) : ControllerBase
    {
        private readonly IMarketPlaceUsers _marketPlaceUsers = marketPlaceUsers;

        [HttpDelete("{id}")]
        public IActionResult DeleteMarketPlaceUser(int id){
            _marketPlaceUsers.DeleteMarketplaceUser(id);
            return Ok();
        }
    }
}