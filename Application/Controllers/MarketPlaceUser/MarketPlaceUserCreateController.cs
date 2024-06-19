using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Application.Interfaces;
using Coupons.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Coupons.Application.Controllers.MarketPlaceUser
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarketPlaceUserCreateController(IMarketPlaceUsers marketPlaceUsers) : ControllerBase
    {
        private readonly IMarketPlaceUsers _marketPlaceUsers = marketPlaceUsers;

        [HttpPost]
        public IActionResult CreateMarketPlaceUsers([FromBody] MarketPlaceUserDto marketPlaceUserDto){
            _marketPlaceUsers.CreateMarketplaceUser(marketPlaceUserDto);
            return Ok();
        }
    }
}