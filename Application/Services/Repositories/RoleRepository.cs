using Coupons.Models;
using Coupons.Application.Interfaces;
using Coupons.Infrastructure.Contexts;

namespace Coupons.Application.Services.Repositories
{
    public class RoleRepository : IRole
    {
         private readonly CouponsContext _context;

        public RoleRepository(CouponsContext context)
        {
            _context = context;
        }
        public void AddRole(Role role)
        {
            throw new NotImplementedException();
        }

        public void DeleteRole(Role role)
        {
            throw new NotImplementedException();
        }

        public Role GetRole(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetRoles()
        {
            return _context.Role.ToList();
        }

        public void UpdateRole(Role role)
        {
            throw new NotImplementedException();
        }
    }
}