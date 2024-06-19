using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Application.Interfaces;
using Coupons.Dtos;
using Coupons.Infrastructure.Contexts;
using Coupons.Models;

namespace Coupons.Application.Services.Repositories
{
    public class BrandRepository(CouponsContext couponsContext) : IBrand
    {
        private readonly CouponsContext _couponsContext = couponsContext;
        public void CreateBrand(BrandDto brandDto)
        {
            Brand oBrand = new(){
                Name = brandDto.Name,
                Nit = brandDto.Nit,
                Country = brandDto.Country,
                City = brandDto.City,
                WebSite = brandDto.WebSite,
                Status = brandDto.Status,
                CreateAt = brandDto.CreateAt                
            };

            _couponsContext.Brand.Add(oBrand);
            _couponsContext.SaveChanges();
        }

        public void DeleteBrand(int id)
        {
            Brand? BrandRemove = _couponsContext.Brand.Find(id);

            if(BrandRemove != null){
                _couponsContext.Brand.Remove(BrandRemove);
                _couponsContext.SaveChanges();
            }
        }

        public IEnumerable<Brand> GetAllBrands()
        {
            return _couponsContext.Brand.ToList();
        }

        public void UpdateBrand(int id, BrandDto brandDto)
        {
            Brand oBrand = new(){
                Id = id,
                Name = brandDto.Name,
                Nit = brandDto.Nit,
                Country = brandDto.Country,
                City = brandDto.City,
                WebSite = brandDto.WebSite,
                Status = brandDto.Status,
                CreateAt = brandDto.CreateAt                
            };

            _couponsContext.Brand.Update(oBrand);
            _couponsContext.SaveChanges();

            
        }
    }
}