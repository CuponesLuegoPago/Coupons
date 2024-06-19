using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Models;

namespace Coupons.Dtos
{
    public class MarketPlaceUserDto
    {
        public required string UserName {get; set;}
        public required string Password {get; set;}
        public required string Email {get; set;}
        public string? Status {get; set;}
        public int BrandId {get; set;}
    }

}