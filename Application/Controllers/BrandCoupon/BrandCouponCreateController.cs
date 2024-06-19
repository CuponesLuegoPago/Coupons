using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Application.Interfaces;
using Coupons.Dtos;
using Coupons.Infrastructure.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace Coupons.Application.Controllers.BrandCoupon
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandCouponCreateController(IBrandCoupon brandCoupon) : ControllerBase
    {
        private readonly IBrandCoupon _brandCoupon = brandCoupon;

        [HttpPost]
        public IActionResult CreateCouponBrand([FromBody] BrandCouponDto brandCouponDto){
            _brandCoupon.CreateBrandCoupon(brandCouponDto);
            return Ok();
        }
    }
}