using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Models;

namespace Coupons.Dtos
{
    public class BrandDto
    {
        public string Name {get; set;}
        public string Nit {get; set;}
        public string Country {get; set;}
        public string City {get; set;}
        public string WebSite {get; set;}
        public string Status {get; set;}
        public string CreateAt {get; set;}
    }
}