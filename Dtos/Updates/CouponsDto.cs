using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupons.Dtos.Updates
{
    public class CouponsDto
    {
        public int Id {get; set;}
        public string? Code {get; set;}
        public string? Name {get; set;}
        public string? Description {get; set;}
        public DateOnly? StartDate {get; set;}
        public DateOnly? EndDate {get; set;}
        public string? DiscountType {get; set;}
        public double? DiscountValue {get; set;}
        public int? UsageLimit {get; set;}
        public double? MinPurchaseAmount {get; set;}
        public double? MaxPurchaseAmount {get; set;}
        public int? CustomerId {get; set;}
        //public Customer Customer {get; set;}
        public string? Status {get; set;}
        public int? CreatedBy {get; set;}
        //public MarketingUser? User {get; set;}
        public DateOnly? CreatedAt {get; set;}
    }
}