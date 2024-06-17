using AutoMapper;
using Coupons.Dtos;
using Coupons.Models;
using Coupons.Application.Interfaces;
using Coupons.Infrastructure.Contexts;
using Coupons.Application.Utils.Profiles;

namespace Coupons.Application.Services
{
    public class CustomersRepository : ICustomers
    {

        private readonly CouponsContext _context;
        private readonly IMapper _mapper;
        public CustomersRepository(CouponsContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //Create a new Customer
        public Customer CreateCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        //Get all Customers
        public List<Customer> GetAllCustomer()
        {
            return _context.Customers.ToList();
        }

        //Get Customer by Id
        public Customer GetCustomerById(int id)
        {
            return _context.Customers.Find(id);
        }

        public Customer UpdateCustomer(CustomerDto customer, int id)
        {
            var customerToUpdate = _context.Customers.Find(id);
            _mapper.Map(customer, customerToUpdate);
            _context.SaveChanges();
            return customerToUpdate;
        }
    }
}