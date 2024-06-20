using AutoMapper;
using Coupons.Dtos;
using Coupons.Models;

namespace Coupons.Application.Utils.Profiles
{
    public class MarketingUserProfile : Profile
    {
         public MarketingUserProfile(){

            CreateMap<MarketingUserDto, MarketingUser>().ForAllMembers(options => options.Condition((src, dest, srcMember) => srcMember != null));
         }
    }
}