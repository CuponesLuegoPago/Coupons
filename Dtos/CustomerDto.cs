using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupons.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set;}
        public string? TypeDocument { get; set;}
        public string? NumDocument { get; set;}
        public string? Name { get; set;}
        public string? LastName { get; set;}
        public string? Phone { get; set;}
        public string? Email { get; set;}
    }
}