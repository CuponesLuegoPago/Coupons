using Coupons.Application.Interfaces;
using Coupons.Models;
using Coupons.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Coupons.Application.Controllers.Coupons
{
    public class CouponCreateController : ControllerBase
    {
        private readonly ICoupons _repository;

        public CouponCreateController(ICoupons repository)
        {
            _repository = repository;
        }

        //Endpoint method for creating a new coupon
        [HttpPost]
        [Route("api/Coupons")]
        public IActionResult CreateCoupon([FromBody] Coupon coupon)
        {
            return Ok(_repository.Create(coupon));
        }
    }
}