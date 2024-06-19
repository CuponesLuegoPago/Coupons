using Coupons.Application.Interfaces;
using Coupons.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coupons.Application.Controllers.BrandCoupon
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandCouponController(IBrandCoupon brandCoupon) : ControllerBase
    {
        private readonly IBrandCoupon _brandCoupon = brandCoupon;

        [HttpGet]
        public IEnumerable<BrandCoupons> GetAllBrandCoupon(){
            return _brandCoupon.GetAllBrandCoupon();
        }
    }
}