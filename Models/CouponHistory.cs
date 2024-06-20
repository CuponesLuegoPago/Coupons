using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupons.Models
{
    public class CouponHistory
    {
        public int Id { get; set; }
        public int? CouponId { get; set; }
        public DateOnly? ChangeDate { get; set; }
        public string? FieldChanged { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public Coupon? coupon { get; set; }
    }
}