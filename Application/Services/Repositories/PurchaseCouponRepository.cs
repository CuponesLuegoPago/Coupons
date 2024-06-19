using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Application.Interfaces;
using Coupons.Dtos;
using Coupons.Infrastructure.Contexts;
using Coupons.Models;
using AutoMapper;

namespace Coupons.Application.Services.Repositories
{
    public class PurchaseCouponRepository : IPurchaseCoupon
    {
        private readonly CouponsContext _context;
        private readonly IMapper _mapper;
        public PurchaseCouponRepository(CouponsContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public PurchaseCoupon Create(PurchaseCoupon purchaseCoupon)
        {
            _context.PurchaseCoupon.Add(purchaseCoupon);
            _context.SaveChanges();
            return purchaseCoupon;
        }

        public List<PurchaseCoupon> GetAllPurchase()
        {
            return _context.PurchaseCoupon.ToList();
        }

        public PurchaseCoupon GetById(int id)
        {
            return _context.PurchaseCoupon.Find(id);
        }

        public PurchaseCoupon Update(int id, PurchaseCouponDto purchaseCoupon)
        {
            var PurchaseCouponDtoUpdate = _context.PurchaseCoupon.Find(id);
            _mapper.Map(purchaseCoupon ,PurchaseCouponDtoUpdate);
            _context.SaveChanges();
            return PurchaseCouponDtoUpdate;
        }
    }
}