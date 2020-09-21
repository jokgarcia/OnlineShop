using OnlineShop.Web.Models;
using System.Collections.Generic;

namespace OnlineShop.Web.Repository
{
    public interface IOnlineShopRepository
    {
        IEnumerable<Customer> GetCustomers();
        Customer UpdateCustomer(Customer customer);
    }
}