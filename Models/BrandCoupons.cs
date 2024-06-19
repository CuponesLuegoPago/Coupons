using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupons.Models
{
    public class BrandCoupons
    {
        public int Id {get; set;}
        public int BrandId {get; set;}
        public Brand? Brand {get; set;}
        public int CouponId {get; set;}
        public Coupon? Coupon {get; set;}
    }
}