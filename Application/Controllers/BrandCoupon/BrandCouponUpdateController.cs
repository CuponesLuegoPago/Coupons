using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Application.Interfaces;
using Coupons.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Coupons.Application.Controllers.BrandCoupon
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandCouponUpdateController(IBrandCoupon brandCoupon) : ControllerBase
    {
        private readonly IBrandCoupon _brandCoupon = brandCoupon;

        [HttpPut("{id}")]
        public IActionResult UpdateBrandCoupon(int id, [FromBody] BrandCouponDto brandCouponDto){
            _brandCoupon.UpdateBrandCoupon(id, brandCouponDto);
            return Ok();
        }

    }
}