using Microsoft.AspNetCore.Mvc;
using Coupons.Application.Services.Repositories;
using Coupons.Dtos;
using Coupons.Models;
using Coupons.Application.Interfaces;

namespace Coupons.Application.Controllers.Customers
{
    public class CustomerCreateController : ControllerBase
    {
        private readonly ICustomers _repository;

        public CustomerCreateController(ICustomers repository)
        {
            _repository = repository;
        }
        
        [HttpPost]
        [Route("api/Customers")]
        public IActionResult CreateCustomer([FromBody] Customer customer)
        {
            return Ok(_repository.CreateCustomer(customer));
        }
    }
}