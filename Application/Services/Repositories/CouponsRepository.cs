using AutoMapper;
using Coupons.Models;
using Coupons.Dtos;
using Coupons.Application.Interfaces;
using Coupons.Infrastructure.Contexts;

namespace Coupons.Application.Services.Repositories
{   
    public class CouponsRepository : ICoupons
    {
        private readonly CouponsContext _context;
        private readonly IMapper _mapper;

        public CouponsRepository(CouponsContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //Create a new Coupon
        public Coupon Create(Coupon coupon)
        {
            _context.Coupons.Add(coupon);
            _context.SaveChanges();
            return coupon;    
        }

        //Get all Coupons
        public List<Coupon> GetAllCoupons()
        {
            return _context.Coupons.ToList();
        }

        //Get Coupon by Id
        public Coupon GetById(int id)
        {
            return _context.Coupons.Find(id);
        }

        //Update a Coupon
        public Coupon Update(int id, CouponsDto coupon)
        {
            var couponToUpdate = _context.Coupons.Find(id);
            _mapper.Map(coupon, couponToUpdate);
            _context.SaveChanges();
            return couponToUpdate;
        }
    }
}