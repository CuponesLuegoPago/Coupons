using Coupons.Application.Interfaces;
using Coupons.Dtos.Updates;

using Microsoft.AspNetCore.Mvc;

namespace Coupons.Application.Controllers.Coupons
{

    public class CouponUpdateController : ControllerBase
    {

        private readonly ICoupons _repository;

        public CouponUpdateController(ICoupons repository)
        {
            _repository = repository;
        }
        //Endpoint method for update a coupon
        [HttpPut]
        [Route("api/Coupons/{id}")]
        public IActionResult UpdateCoupon([FromBody] CouponsDto coupon, int id)
        {
            return Ok(_repository.Update(id, coupon));
        }
    }
}