using Coupons.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Coupons.Application.Controllers.CouponsHistory
{
    public class CouponsHistoryConstroller : ControllerBase
    {
        private readonly ICouponHistory _couponHistory;
        public CouponsHistoryConstroller(ICouponHistory couponHistory)
        {
            _couponHistory = couponHistory;
        }

        [HttpGet]
        [Route("api/CouponsHistory")]
        [Authorize]
        public IActionResult GetAllHistories()
        {
            return Ok(_couponHistory.GetAllHistories());
        }

        [HttpGet]
        [Route("api/CouponsHistory/{id}")]
        public IActionResult GetHistoryById(int id)
        {
            return Ok(_couponHistory.GetHistoryById(id));
        }
    }
}