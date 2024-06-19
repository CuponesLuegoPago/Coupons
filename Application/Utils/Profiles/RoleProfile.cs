using AutoMapper;
using Coupons.Dtos;
using Coupons.Models;

namespace Coupons.Application.Utils.Profiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile(){
            CreateMap<UserRolDto, UserRol>().ForAllMembers(options => options.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}