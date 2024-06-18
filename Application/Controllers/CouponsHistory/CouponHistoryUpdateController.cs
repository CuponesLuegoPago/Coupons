using Coupons.Application.Interfaces;
using Coupons.Dtos.Updates;
using Microsoft.AspNetCore.Mvc;

namespace Coupons.Application.Controllers.CouponsHistory
{
    public class CouponHistoryUpdateController : ControllerBase
    {
         private readonly ICouponHistory _couponHistory;
        public CouponHistoryUpdateController(ICouponHistory couponHistory)
        {
            _couponHistory = couponHistory;
        }

        //Endpoint method for updating an existing coupon history
        [HttpPut]
        [Route("api/CouponsHistory/{id}")]
        public IActionResult UpdateHistory([FromBody] CouponHistoryDto history, int id)
        {
            return Ok(_couponHistory.UpdateHistory(history, id));
        }
    }
}