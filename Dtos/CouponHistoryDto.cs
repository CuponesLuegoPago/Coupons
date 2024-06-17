using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupons.Dtos
{
    public class CouponHistoryDto
    {
        public int Id { get; set; }
        public int? CouponId { get; set; }
        public DateOnly? ChangeDate { get; set; }
        public string? FielChanged { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
    }
}