using AutoMapper;
using Coupons.Dtos;
using Coupons.Models;

namespace Coupons.Application.Utils.Profiles
{
    public class CouponUsageProfile : Profile
    {
        public CouponUsageProfile(){
            CreateMap<CouponUsageDto, CouponUsage>().ForAllMembers(options => options.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}