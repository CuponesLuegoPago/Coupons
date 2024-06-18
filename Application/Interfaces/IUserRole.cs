using Coupons.Models;

namespace Coupons.Application.Interfaces
{
    public interface IUserRole
    {
         IEnumerable<UserRol> GetUserRols();

        Role GetRol(int id);

        void addUserRol(UserRol userRol);
        void UpdateUserRol(UserRol userRol);
        void DeleteRol(UserRol userRol);
    }
}