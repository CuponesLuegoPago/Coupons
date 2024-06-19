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
        public DbSet<CouponUsage> CouponUsage { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<PurchaseCoupon> PurchaseCoupon { get; set; }
    }
}