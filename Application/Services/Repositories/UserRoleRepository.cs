using Coupons.Models;
using Coupons.Application.Interfaces;
using Coupons.Infrastructure.Contexts;

namespace Coupons.Application.Services.Repositories
{
    public class UserRoleRepository : IUserRole
    {
         private readonly CouponsContext _context;

        public UserRoleRepository(CouponsContext context)
        {
            _context = context;
        }
        public void addUserRol(UserRol userRol)
        {
            throw new NotImplementedException();
        }

        public void DeleteRol(UserRol userRol)
        {
            throw new NotImplementedException();
        }

        public Role GetRol(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserRol> GetUserRols()
        {
            return _context.UserRole.ToList();
        }

        public void UpdateUserRol(UserRol userRol)
        {
            throw new NotImplementedException();
        }
    }
}