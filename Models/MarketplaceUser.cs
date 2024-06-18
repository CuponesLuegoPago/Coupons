using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupons.Models
{
    public class MarketplaceUser
    {
        public int Id {get; set;}
        public required string UserName {get; set;}
        public required string Password {get; set;}
        public required string Email {get; set;}
        public string? Status {get; set;}
        public int BrandId {get; set;}
        public Brand? Brand {get; set;}


    }
}