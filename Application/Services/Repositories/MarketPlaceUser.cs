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
    public class MarketPlaceUser(CouponsContext couponsContext) : IMarketPlaceUsers
    {
        private readonly CouponsContext _couponsContext = couponsContext;

        public void CreateMarketplaceUser(MarketPlaceUserDto marketPlaceUserDto)
        {
            var oMarketplaceUser = new MarketplaceUser
            {
                UserName = marketPlaceUserDto.UserName,
                Password = marketPlaceUserDto.Password,
                Email = marketPlaceUserDto.Email,
                Status = marketPlaceUserDto.Status,
                BrandId = marketPlaceUserDto.BrandId
            };

            _couponsContext.MarketplaceUser.Add(oMarketplaceUser);
            _couponsContext.SaveChanges();
        }

        public void DeleteMarketplaceUser(int id)
        {
            MarketplaceUser? remove = _couponsContext.MarketplaceUser.Find(id);

            if(remove != null){
                _couponsContext.MarketplaceUser.Remove(remove);
                _couponsContext.SaveChanges();
            }

        }

        public IEnumerable<MarketplaceUser> GetMarketplaceUser()
        {
            return _couponsContext.MarketplaceUser.ToList();
        }

        public void UpdateMarketplaceUser(int id,MarketPlaceUserDto marketplaceUserDto)
        {
            var oMarketplaceUser = new MarketplaceUser
            {
                UserName = marketplaceUserDto.UserName,
                Password = marketplaceUserDto.Password,
                Email = marketplaceUserDto.Email,
                Status = marketplaceUserDto.Status,
                BrandId = marketplaceUserDto.BrandId
            };

            oMarketplaceUser.Id = id;

            _couponsContext.MarketplaceUser.Update(oMarketplaceUser);
        }
    }
}