using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Dtos;
using Coupons.Models;

namespace Coupons.Application.Interfaces
{
    public interface IMarketPlaceUsers
    {
        public IEnumerable<MarketplaceUser> GetMarketplaceUser();
        public void CreateMarketplaceUser(MarketPlaceUserDto marketplaceUserDto);
        public void UpdateMarketplaceUser(int id,MarketPlaceUserDto marketplaceUserDto);
        public void DeleteMarketplaceUser(int id);
    }
}