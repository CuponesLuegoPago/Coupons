using AutoMapper;
using Coupons.Dtos;
using Coupons.Models;
using Coupons.Application.Interfaces;
using Coupons.Infrastructure.Contexts;

namespace Coupons.Application.Services.Repositories
{
    public class MarketingUserRepository : IMarketingUser
    {
        private readonly CouponsContext _context;
        private readonly IMapper _mapper;
        public MarketingUserRepository(CouponsContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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

        public MarketingUser UpdateMarketingUser(MarketingUserDto marketingUser, int Id)
        {
            var oldMarketingUser = _context.MarketingUser.Find(Id);
            _mapper.Map(marketingUser, oldMarketingUser);
            _context.SaveChanges();
            return oldMarketingUser;
        }

        public void AddMarketingUser(MarketingUser marketingUser)
        {
            _context.MarketingUser.Add(marketingUser);
            _context.SaveChanges();
        }
    }
}