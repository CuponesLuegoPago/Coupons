using Coupons.Models;
using Coupons.Application.Interfaces;
using Coupons.Infrastructure.Contexts;
namespace Coupons.Application.Services.Repositories
{
    public class MarketingUserRepository : IMarketingUser
    {
         private readonly CouponsContext _context;

        public MarketingUserRepository(CouponsContext context)
        {
            _context = context;
        }

        public void DeleteMarketingUser(MarketingUser marketingUser)
        {
            throw new NotImplementedException();
        }

        public MarketingUser GetMarketingUser(int Id)
        {
            return _context.MarketingUser.Find(Id);
        }

        public IEnumerable<MarketingUser> GetMarketingUsers()
        {
            return _context.MarketingUser.ToList();
        }

        public void UpdateMarketingUser(MarketingUser marketingUser)
        {
            throw new NotImplementedException();
        }

        public void AddMarketingUser(MarketingUser marketingUser)
        {
            _context.MarketingUser.Add(marketingUser);
            _context.SaveChanges();
        }
    }
}