using Coupons.Models;
using Coupons.Application.Interfaces;
using Coupons.Infrastructure.Contexts;
using Coupons.Dtos;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Coupons.Application.Services.Repositories
{
    public class UserRoleRepository : IUserRole
    {
        private readonly CouponsContext _context;
        private readonly IMapper _mapper;
        public UserRoleRepository(CouponsContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public UserRol addUserRol(UserRol userRol)
        {
            _context.UserRole.Add(userRol);
            _context.SaveChanges();
            return userRol;
        }

        public void DeleteRol(UserRol userRol)
        {
            throw new NotImplementedException();
        }

        public Role GetRol(int id)
        {
            return _context.Role.Find(id);
        }

        public IEnumerable<UserRol> GetUserRols()
        {
            return _context.UserRole.Include(u => u.MarketingUser).Include(r => r.Role).ToList();
        }

        public UserRol UpdateUserRol(UserRolDto userRol, int Id)
        {
            var oldUserRol = _context.UserRole.Find(Id);
            _mapper.Map(userRol, oldUserRol);
            _context.SaveChanges();
            return oldUserRol;
        }
    }
}