using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupons.Models
{
    public class MarketplaceUser
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public int? BrandId { get; set; }
        public Brand? Brand { get; set; }
        public string? Status { get; set; }
        public List<CouponUsage>? CouponUsage { get; set; }
    }
}