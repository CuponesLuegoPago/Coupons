using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupons.Dtos
{
    public class PurchaseCouponDto
    {
        public int Id { get; set; }
        public int PurchaseId { get; set; }
        public int CouponId { get; set; }
    }
}