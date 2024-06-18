using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Application.Interfaces;
using Coupons.Dtos;
using Coupons.Models;
using Coupons.Infrastructure.Contexts;
using AutoMapper;

namespace Coupons.Application.Services.Repositories
{
    public class CouponUsageRepository : ICouponUsage
    {
        private readonly CouponsContext _context;
        private readonly ICoupons _coupons;
        private readonly IMapper _mapper;

        public CouponUsageRepository(CouponsContext context, IMapper mapper, ICoupons coupons)
        {
            _context = context;
            _mapper = mapper;
            _coupons = coupons;
        }

        public List<CouponUsage> GetAllCoupons()
        {
            return _context.CouponUsage.ToList();
        }

        public CouponUsage GetById(int id)
        {
            return _context.CouponUsage.Find(id);
        }

        public CouponUsage Update(int id, CouponUsageDto couponUsage)
        {
            var CouponUsageDtoUpdate = _context.CouponUsage.Find(id);
            _mapper.Map(couponUsage, CouponUsageDtoUpdate);
            _context.SaveChanges();
            return CouponUsageDtoUpdate;

        }

      public CouponUsage Create(int couponId, CouponUsageDto couponUsageDto)
{
    // Encuentra el cupón por id
    var coupon = _context.Coupons.FirstOrDefault(c => c.Id == couponId);
    if (coupon == null)
    {
        throw new KeyNotFoundException("Cupón no encontrado.");
    }

    // Validaciones antes de guardar los cambios
    if (couponUsageDto.TransactionAmount < coupon.MinPurchaseAmount)
    {
        throw new InvalidOperationException("El monto de la transacción no puede ser menor que el monto mínimo de compra del cupón.");
    }
    if (couponUsageDto.TransactionAmount > coupon.MaxPurchaseAmount)
    {
        throw new InvalidOperationException("El monto de la transacción no puede ser mayor que el monto máximo de compra del cupón.");
    }

    // Verifica que el UsageLimit no sea 0
    if (coupon.UsageLimit <= 0)
    {
        throw new InvalidOperationException("El cupón ha alcanzado su límite de uso y no puede ser aplicado.");
    }

    // Resta 1 del UsageLimit si las validaciones son correctas
    coupon.UsageLimit -= 1;
    
    using (var transaction = _context.Database.BeginTransaction())
    {
        try
        {
            _context.Coupons.Update(coupon);

            // Mapea el DTO a la entidad CouponUsage y añádelo al contexto
            var couponUsage = _mapper.Map<CouponUsage>(couponUsageDto);
            _context.CouponUsage.Add(couponUsage);

            // Guarda los cambios en la base de datos
            _context.SaveChanges();
            
            transaction.Commit();
            
            return couponUsage;
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }
}




    }
} 