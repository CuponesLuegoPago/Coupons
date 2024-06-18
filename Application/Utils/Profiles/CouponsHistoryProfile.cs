using AutoMapper;
using Coupons.Dtos.Updates;
using Coupons.Models;

namespace Coupons.Application.Utils.Profiles
{
    public class CouponsHistoryProfile : Profile
    {
        public CouponsHistoryProfile(){
            CreateMap<CouponHistoryDto, CouponHistory>().ForAllMembers(options => options.Condition((src, dest, srcMember) => srcMember != null));;
        }
    }
}