using Coupons.Models;
using Coupons.Dtos.Updates;

namespace Coupons.Application.Interfaces
{
    public interface ICoupons
    {
        //Get all Coupons
        List<Coupon> GetAllCoupons();

        //Get Coupon by Id
        Coupon GetById(int id);

        //Create Coupon
        Coupon Create(Coupon coupon);

        //Update Coupon
        Coupon Update(int id, CouponsDto coupon);
    } 
}