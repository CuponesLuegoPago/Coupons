using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Dtos;
using Coupons.Models;

namespace Coupons.Application.Interfaces
{
    public interface IPurchaseCoupon
    {
         List<PurchaseCoupon> GetAllPurchase();

        PurchaseCoupon GetById(int id);

        PurchaseCoupon Create(PurchaseCoupon purchaseCoupon);

        PurchaseCoupon Update(int id,PurchaseCouponDto  purchaseCoupon);
    }
}