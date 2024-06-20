using AutoMapper;
using Coupons.Dtos;
using Coupons.Models;
using Coupons.Application.Interfaces;
using Coupons.Infrastructure.Contexts;

namespace Coupons.Application.Services.Repositories
{
    public class RoleRepository : IRole
    {
        private readonly CouponsContext _context;
        private readonly IMapper _mapper;
        public RoleRepository(CouponsContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Role AddRole(Role role)
        {
            _context.Role.Add(role);
            _context.SaveChanges();
            return role;
        }

        public void DeleteRole(Role role)
        {
            throw new NotImplementedException();
        }

        public Role GetRole(int Id)
        {
            return _context.Role.Find(Id);
        }

        public IEnumerable<Role> GetRoles()
        {
            return _context.Role.ToList();
        }

        public Role UpdateRole(Role role, int Id)
        {
            _context.Role.Update(role);
            _context.SaveChanges();
            return role;
        }
    }
}