using Coupons.Dtos;
using Coupons.Models;

namespace Coupons.Application.Interfaces
{
    public interface IRole
    {
        IEnumerable<Role> GetRoles();

        Role GetRole(int Id);

        Role AddRole(Role role);
        Role UpdateRole(Role role, int Id);
        void DeleteRole(Role role);
    }
}