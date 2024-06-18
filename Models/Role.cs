using System.Text.Json.Serialization;

namespace Coupons.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [JsonIgnore]
        public List<UserRol>? userRols { get; set; }
    }
}