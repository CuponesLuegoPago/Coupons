using Coupons.Dtos.Updates;
using Coupons.Models;

namespace Coupons.Application.Interfaces
{
    public interface ICouponHistory
    {
        //Get all histories
        List<CouponHistory> GetAllHistories();

        //Get history by id
        CouponHistory GetHistoryById(int id);

        //Create a new history
        CouponHistory CreateHistory(CouponHistory history);
        
        //Update a history
        CouponHistory UpdateHistory(CouponHistoryDto history, int id);
    }
}