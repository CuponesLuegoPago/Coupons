using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupons.Models
{
    public class BrandCoupon
    {
        public int Id {get; set;}
        public int BrandId {get; set;}
        public int CouponId {get; set;}
    }
}