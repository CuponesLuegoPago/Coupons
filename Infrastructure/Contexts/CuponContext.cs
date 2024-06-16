using Microsoft.EntityFrameworkCore;
namespace Coupons.Infrastructure.Contexts
{
    public class CuponContext : DbContext
    {
        public CuponContext(DbContextOptions<CuponContext> options) : base(options){
            
        }
    }
}