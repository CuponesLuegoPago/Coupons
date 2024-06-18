using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Application.Interfaces;
using Coupons.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Coupons.Application.Controllers.CouponUsage
{
    [ApiController]
    [Route("api/[controller]")]
    public class CouponUsageUpdateController : ControllerBase
    {
        private readonly ICouponUsage _repository;

        public CouponUsageUpdateController(ICouponUsage repository)
        {
            _repository = repository;
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateCoupon([FromBody] CouponUsageDto couponUsage, int id)
        {
            return Ok(_repository.Update(id, couponUsage));
        }
    }
}