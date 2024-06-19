namespace Coupons.Models
{
    public class UserRol
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public Role? Role { get; set; }
        public MarketingUser? MarketingUser { get; set; }
    }
}