using Coupons.Dtos;
using Coupons.Models;

namespace Coupons.Application.Interfaces
{
    public interface IMarketingUser
    {
         IEnumerable<MarketingUser> GetMarketingUsers();

        MarketingUser GetMarketingUser(int Id);

        MarketingUser AddMarketingUser(MarketingUser marketingUser);
        MarketingUser UpdateMarketingUser(MarketingUserDto marketingUser, int Id);
        void DeleteMarketingUser(MarketingUser marketingUser);
    }
}