using AutoMapper;
using Coupons.Models;
using Coupons.Dtos.Updates;
using Coupons.Application.Interfaces;
using Coupons.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Coupons.Application.Services.Repositories
{
    public class CouponsHistoryRepository : ICouponHistory
    {
        private readonly CouponsContext _context;
        private readonly IMapper _mapper;

        public CouponsHistoryRepository(CouponsContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //Create a new History
        public CouponHistory CreateHistory(CouponHistory history)
        {
            _context.CouponHistory.Add(history);
            _context.SaveChanges();
            return history;
        }

        //Get all histories
        public List<CouponHistory> GetAllHistories()
        {
            return _context.CouponHistory.Include(u => u.coupon).ToList();
        }

        //Get history by id
        public CouponHistory GetHistoryById(int id)
        {
            return _context.CouponHistory.Include(u => u.coupon).FirstOrDefault(u => u.Id == id);
        }

        //Update a history
        public CouponHistory UpdateHistory(CouponHistoryDto history, int id)
        {
            var couponHistory = _context.CouponHistory.Find(id);
            _mapper.Map(history, couponHistory);
            _context.SaveChanges();
            return couponHistory;
        }
    }
}