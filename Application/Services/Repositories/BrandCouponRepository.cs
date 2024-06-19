using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Application.Interfaces;
using Coupons.Dtos;
using Coupons.Infrastructure.Contexts;
using Coupons.Models;

namespace Coupons.Application.Services.Repositories
{
    public class  BrandCouponRepository(CouponsContext couponsContext) : IBrandCoupon
    {
        private readonly CouponsContext _couponsContext = couponsContext;
        public void CreateBrandCoupon(BrandCouponDto brandCouponDto)
        {
            BrandCoupons oBrandCoupon = new ()
            {
                BrandId = brandCouponDto.BrandId,
                CouponId = brandCouponDto.CouponId
            };

            _couponsContext.BrandCoupon.Add(oBrandCoupon);
            _couponsContext.SaveChanges();
        }

        public void DeleteBrandCoupon(int id)
        {
            BrandCoupons? brandCoupon = _couponsContext.BrandCoupon.Find(id);
            if(brandCoupon != null){
                _couponsContext.BrandCoupon.Remove(brandCoupon);
            }
        }

        public IEnumerable<BrandCoupons> GetAllBrandCoupon()
        {
            return _couponsContext.BrandCoupon.ToList();
        }

        public void UpdateBrandCoupon(int id, BrandCouponDto brandCouponDto)
        {
            BrandCoupons? brandCoupon = _couponsContext.BrandCoupon.Find(id);

            if(brandCoupon != null){
                brandCoupon.BrandId = brandCouponDto.BrandId;
                brandCoupon.CouponId = brandCouponDto.CouponId;
                _couponsContext.BrandCoupon.Update(brandCoupon);
                _couponsContext.SaveChanges();
            }
        }
    }
}