using Coupons.Models;
using Coupons.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Coupons.Controllers.MarketingUsers
{
    [ApiController]
    public class MarketingUserUpdateController
    {
        private readonly IMarketingUser _marketingUserRepository;

        public MarketingUserUpdateController(IMarketingUser marketingUserRepository)
        {
            _marketingUserRepository = marketingUserRepository;
        }

       
    }
}