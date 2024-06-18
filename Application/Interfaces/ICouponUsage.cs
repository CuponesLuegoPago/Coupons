using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Models;
using Coupons.Dtos;

namespace Coupons.Application.Interfaces
{
    public interface ICouponUsage
    {
        //Get all CouponUsage
        List<CouponUsage> GetAllCoupons();

        //Get CouponUsage by Id
        CouponUsage GetById(int id);

        //Update CouponUsage
        CouponUsage Update(int id, CouponUsageDto couponUsage);

        //Create CouponUsage
        CouponUsage Create(int couponId, CouponUsageDto couponUsageDto);

    }
}