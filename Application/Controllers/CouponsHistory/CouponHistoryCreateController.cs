using Coupons.Application.Interfaces;
using Coupons.Models;
using Coupons.Dtos;

using Microsoft.AspNetCore.Mvc;

namespace Coupons.Application.Controllers.CouponsHistory
{
    public class CouponHistoryCreateController : ControllerBase
    {
        private readonly ICouponHistory _couponHistory;
        public CouponHistoryCreateController(ICouponHistory couponHistory)
        {
            _couponHistory = couponHistory;
        }

        //Endpoint method for creating a new coupon history
        [HttpPost]
        [Route("api/CouponsHistory")]
        public IActionResult CreateHistory([FromBody] CouponHistory couponHistory)
        {
            return Ok(_couponHistory.CreateHistory(couponHistory));
        }
    }
}