using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Coupons.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Nit { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? WebSite { get; set; }
        public string? Status { get; set; }
        [JsonIgnore]
        public List<BrandCoupon>? BrandCoupon { get; set; }
        [JsonIgnore]
        public List<MarketplaceUser>? MarketplaceUser { get; set; }
    }
}