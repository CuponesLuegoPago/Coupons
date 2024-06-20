using Microsoft.AspNetCore.Mvc;
using Coupons.Dtos;
using Coupons.Application.Interfaces;

namespace Coupons.Controllers.MarketingUsers
{
    public class MarketingUserUpdateController : ControllerBase
    {
        private readonly IMarketingUser _marketingUserRepository;

        public MarketingUserUpdateController(IMarketingUser marketingUserRepository)
        {
            _marketingUserRepository = marketingUserRepository;
        }

        [HttpPut]
        [Route("api/MarketingUsers/{id}")]
        public IActionResult UpdateCustomer([FromBody] MarketingUserDto customer, int id)
        {
            return Ok(_marketingUserRepository.UpdateMarketingUser(customer, id));
        }
       
    }
}