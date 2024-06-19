using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Coupons.Application.Controllers.BrandCoupon
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandCouponDeleteController(IBrandCoupon brandCoupon) : ControllerBase
    {
        private readonly IBrandCoupon _brandCoupon = brandCoupon;

        [HttpDelete]
        public IActionResult DeleteBrandCoupon(int id){
            _brandCoupon.DeleteBrandCoupon(id);
            return Ok();
        }
    }
}