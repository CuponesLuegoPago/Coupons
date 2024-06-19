using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Coupons.Dtos;
using Coupons.Models;


namespace Coupons.Application.Utils.Profiles
{
    public class PurchaseCouponProfile : Profile
    {
        public PurchaseCouponProfile()
        {
            CreateMap<PurchaseCouponDto, PurchaseCoupon>().ForAllMembers(options => options.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}