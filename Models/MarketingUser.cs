using System.Text.Json.Serialization;

namespace Coupons.Models
{
    public class MarketingUser 
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        [JsonIgnore]
        public List<UserRol>? UserRols { get; set;}

    }
}