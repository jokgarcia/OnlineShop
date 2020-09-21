using Microsoft.EntityFrameworkCore;
using OnlineShop.Web.Context;
using OnlineShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Repository
{
    public class OnlineShopRepository : IOnlineShopRepository
    {
        OnlineShopContext context;

        int Age;

        public OnlineShopRepository(OnlineShopContext _context)
        {
            context = _context;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return context.Customers.ToList();
        }

        public Customer UpdateCustomer(Customer customer)
        {
            context.Attach(customer).State = EntityState.Modified;
            context.SaveChanges();
            return customer;
        }

        //Encapsulation
        private int ComputeAge()
        {
            Age = 40;
            return Age;
        }
    }
}
