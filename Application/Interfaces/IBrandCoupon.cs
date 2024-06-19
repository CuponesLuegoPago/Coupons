using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Dtos;
using Coupons.Infrastructure.Contexts;
using Coupons.Models;

namespace Coupons.Application.Interfaces
{
    public interface IBrandCoupon
    {
        public IEnumerable<BrandCoupons> GetAllBrandCoupon();
        public void CreateBrandCoupon(BrandCouponDto brandCouponDto);
        public void UpdateBrandCoupon(int id, BrandCouponDto brandCouponDto);
        public void DeleteBrandCoupon(int id);
    }
}