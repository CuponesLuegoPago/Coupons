using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Application.Interfaces;
using Coupons.Dtos;
using Coupons.Infrastructure.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace Coupons.Application.Controllers.MarketPlaceUser
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketPlaceUserUpdateController(IMarketPlaceUsers marketPlaceUsers) : ControllerBase
    {
        private readonly IMarketPlaceUsers _marketPlaceUsers = marketPlaceUsers;

        [HttpPut("{id}")]
        public IActionResult UpdateMarketPlaceUser(int id,[FromBody] MarketPlaceUserDto marketPlaceUserDto){
            _marketPlaceUsers.UpdateMarketplaceUser(id, marketPlaceUserDto);
            return Ok();
        }
    }
}