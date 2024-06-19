using AutoMapper;
using Coupons.Dtos;
using Coupons.Models;

namespace Coupons.Application.Utils.Profiles
{
    public class PurchaseProfile : Profile
    {
        public PurchaseProfile()
        {
            CreateMap<PurchaseDto, Purchase>().ForAllMembers(options => options.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}