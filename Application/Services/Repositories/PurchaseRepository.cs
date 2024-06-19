using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Application.Interfaces;
using Coupons.Dtos;
using Coupons.Models;
using Coupons.Infrastructure.Contexts;
using AutoMapper;
using Coupons.Application.Utils.Profiles;


namespace Coupons.Application.Services.Repositories
{
    public class PurchaseRepository : IPurchase
    {
        private readonly CouponsContext _context;
        private readonly IMapper _mapper;
        public PurchaseRepository(CouponsContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Purchase Create(Purchase purchase)
        {
            _context.Purchase.Add(purchase);
            _context.SaveChanges();
            return purchase;
        }

        public List<Purchase> GetAllPurchase()
        {
            return _context.Purchase.ToList();
        }

        public Purchase GetById(int id)
        {
            return _context.Purchase.Find(id);
        }

        public Purchase Update(int id, PurchaseDto purchase)
        {
            var PurchaseDtoUptade = _context.Purchase.Find(id);
            _mapper.Map(purchase, PurchaseDtoUptade);
            _context.SaveChanges();
            return PurchaseDtoUptade;
        }
    }
}