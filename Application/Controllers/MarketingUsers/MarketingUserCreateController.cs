using Coupons.Models;
using Coupons.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Coupons.Controllers.MarketingUsers
{
    [ApiController]
    public class MarketingUserCreateController : ControllerBase
    {
        private readonly IMarketingUser _marketingUserRepository;

        public MarketingUserCreateController(IMarketingUser marketingUserRepository)
        {
            _marketingUserRepository = marketingUserRepository;
        }

        // Crear nuevo Usuario de Marteting
        [HttpPost]
        [Route("api/marketingUsers")]
        public IActionResult CreateMarketingUser([FromBody] MarketingUser marketingUser)
        {
            try
            {
                _marketingUserRepository.AddMarketingUser(marketingUser);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}