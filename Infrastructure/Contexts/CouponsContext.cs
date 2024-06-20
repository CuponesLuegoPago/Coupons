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
        public DbSet<MarketingUser> MarketingUser { get; set; }
        public DbSet<UserRol> UserRole { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Prueba> Pruebas {get; set; }
    }
}