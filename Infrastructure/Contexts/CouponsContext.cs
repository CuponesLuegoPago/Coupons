using Microsoft.EntityFrameworkCore;
using Coupons.Models;
namespace Coupons.Infrastructure.Contexts
{
    public class CouponsContext : DbContext
    {
        public CouponsContext(DbContextOptions<CouponsContext> options) : base(options){
            
        }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CouponHistory> CouponHistory { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<BrandCoupons> BrandCoupon {get; set;}
        public DbSet<MarketplaceUser> MarketplaceUser {get; set;}
    }
}