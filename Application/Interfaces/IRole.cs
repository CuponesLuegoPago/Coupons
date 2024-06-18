using Coupons.Models;

namespace Coupons.Application.Interfaces
{
    public interface IRole
    {
        IEnumerable<Role> GetRoles();

        Role GetRole(int Id);

        void AddRole(Role role);
        void UpdateRole(Role role);
        void DeleteRole(Role role);
    }
}