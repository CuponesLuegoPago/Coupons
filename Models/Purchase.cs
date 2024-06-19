using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupons.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime? Date { get; set; }
        public Double Amount { get; set; }
    }
}