using Coupons.Models;

namespace Coupons.Application.Interfaces
{
    public interface IMarketingUser
    {
         IEnumerable<MarketingUser> GetMarketingUsers();

        MarketingUser GetMarketingUser(int Id);

        void AddMarketingUser(MarketingUser marketingUser);
        void UpdateMarketingUser(MarketingUser marketingUser);
        void DeleteMarketingUser(MarketingUser marketingUser);
    }
}