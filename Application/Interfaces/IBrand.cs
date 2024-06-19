using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Dtos;
using Coupons.Models;

namespace Coupons.Application.Interfaces
{
    public interface IBrand
    {
        public IEnumerable<Brand> GetAllBrands();
        public void CreateBrand(BrandDto brandDto);
        public void UpdateBrand(int id,BrandDto brandDto);
        public void DeleteBrand(int id);
    }
}