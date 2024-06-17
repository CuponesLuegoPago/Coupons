using Microsoft.AspNetCore.Mvc;
using Coupons.Application.Services.Repositories;
using Coupons.Dtos;
using Coupons.Models;
using Coupons.Application.Interfaces;


namespace Coupons.Application.Controllers.Customers
{
    public class CustomerUpdateController : ControllerBase
    {

        private readonly ICustomers _repository;

        public CustomerUpdateController(ICustomers repository)
        {
            _repository = repository;
        }
        [HttpPut]
        [Route("api/Customers/{id}")]
        public IActionResult UpdateCustomer([FromBody] CustomerDto customer, int id)
        {
            return Ok(_repository.UpdateCustomer(customer, id));
        }
    }
}