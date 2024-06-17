using AutoMapper;
using Coupons.Dtos;
using Coupons.Models;

namespace Coupons.Application.Utils.Profiles
{
    public class CouponsProfile : Profile
    {
        public CouponsProfile()
        {
            CreateMap<CouponsDto, Coupon>();
            CreateMap<Coupon, CouponsDto>();
        }
    }
}