using Microsoft.AspNetCore.Mvc;
using Coupons.Application.Services.Repositories;
using Coupons.Dtos;
using Coupons.Models;
using Coupons.Application.Interfaces;

namespace Coupons.Application.Controllers.Customers
{
    public class CustomersController : ControllerBase
    {
        private readonly ICustomers _repository;

        public CustomersController(ICustomers repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("api/Customers")]
        public IActionResult GetAllCustomers()
        {
            return Ok(_repository.GetAllCustomer());
        }

        [HttpGet]
        [Route("api/Customers/{id}")]
        public IActionResult GetCustomerById(int id)
        {
            return Ok(_repository.GetCustomerById(id));
        }
    }
}