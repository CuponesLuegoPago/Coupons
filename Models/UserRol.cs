namespace Coupons.Models
{
    public class UserRol
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public Role? UserRole { get; set; }
        public MarketingUser? UserManagementUser { get; set; }
    }
}