using AutoMapper;
using Coupons.Dtos.Updates;
using Coupons.Models;

namespace Coupons.Application.Utils.Profiles
{
    public class CouponsProfile : Profile
    {
        public CouponsProfile()
        {
            CreateMap<CouponsDto, Coupon>().ForAllMembers(options => options.Condition((src, dest, srcMember) => srcMember != null));;
        }
    }
}