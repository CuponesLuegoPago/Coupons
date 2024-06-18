using Coupons.Models;
using Coupons.Dtos;

namespace Coupons.Application.Interfaces
{
    public interface ICoupons
    {
        //Get all CouponUsage
        List<Coupon> GetAllCoupons();

        //Get CouponUsage by Id
        Coupon GetById(int id);

        //Create CouponUsage
        Coupon Create(Coupon coupon);

        //Update CouponUsage
        Coupon Update(int id, CouponsDto coupon);
    }
}