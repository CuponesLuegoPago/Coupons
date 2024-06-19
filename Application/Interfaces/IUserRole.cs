using Coupons.Dtos;
using Coupons.Models;

namespace Coupons.Application.Interfaces
{
    public interface IUserRole
    {
         IEnumerable<UserRol> GetUserRols();

        UserRol GetRol(int id);

        UserRol addUserRol(UserRol userRol);
        UserRol UpdateUserRol(UserRolDto userRol, int Id);
        void DeleteRol(UserRol userRol);
    }
}