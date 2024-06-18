using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupons.Dtos
{
    public class CouponUsageDto
    {
        public int CouponId { get; set; }
        public int UserId { get; set; }
        public DateTime UsageDate { get; set; }
        public Double TransactionAmount  { get; set; }
    }
}