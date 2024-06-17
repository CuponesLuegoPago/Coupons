using AutoMapper;
using Coupons.Dtos;
using Coupons.Models;

namespace Coupons.Application.Utils.Profiles
{
    public class CouponsHistoryProfile : Profile
    {
        public CouponsHistoryProfile(){
            CreateMap<CouponHistoryDto, CouponHistory>();
            CreateMap<CouponHistory, CouponHistoryDto>();
        }
    }
}