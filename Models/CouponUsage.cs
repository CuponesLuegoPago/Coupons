using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupons.Models
{
    public class CouponUsage
    {
        public int Id { get; set; }
        public int? CouponId { get; set; }
        public int? UserId { get; set; }
        public DateOnly? UsageDate { get; set; }
        public double? TransactionAmount { get; set; }
        public MarketplaceUser? User { get; set; }
        public Coupon? Coupon { get; set; }
    }
}