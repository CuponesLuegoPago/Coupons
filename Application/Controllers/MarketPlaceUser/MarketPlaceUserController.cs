using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Application.Interfaces;
using Coupons.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coupons.Application.Controllers.MarketPlaceUser
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarketPlaceUserController(IMarketPlaceUsers marketPlaceUsers) : ControllerBase
    {
        private readonly IMarketPlaceUsers _marketPlaceUsers = marketPlaceUsers;

        [HttpGet]
        public IEnumerable<MarketplaceUser> GetMarketplaceUsers(){
            return _marketPlaceUsers.GetMarketplaceUser();
        }
    }
}