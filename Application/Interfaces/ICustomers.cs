using Coupons.Models;
using Coupons.Dtos.Updates;

namespace Coupons.Application.Interfaces
{
    public interface ICustomers
    {
        //function to get all customers
        List<Customer> GetAllCustomer();

        //function to get a customer by id
        Customer GetCustomerById(int id);

        //function to create a customer
        Customer CreateCustomer(Customer customer);

        //function to update a customer
        Customer UpdateCustomer(CustomerDto customer, int id);
    }
}