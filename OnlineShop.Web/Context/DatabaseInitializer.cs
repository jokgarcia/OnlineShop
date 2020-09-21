using OnlineShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Context
{
    public static class DatabaseInitializer
    {
        public static void Initialize(OnlineShopContext context) 
        {
            context.Database.EnsureCreated();
            //INSERT SAMPLE DATA

            var customer1 = new Customer() 
            {
               FirstName = "Lebron",
               LastName = "James",
               Phone1 = "7777",
               Email = "lakers@gmail.com",
               Address1 = "QC"
            };
            context.Customers.Add(customer1);
            context.SaveChanges();


            var customer2 = new Customer()
            {
                FirstName = "Jok",
                LastName = "Jokic",
                Phone1 = "7777",
                Email = "lakers@gmail.com",
                Address1 = "QC"
            };
            context.Customers.Add(customer2);
            context.SaveChanges();

            var customer3 = new Customer()
            {
                FirstName = "John",
                LastName = "Cruz",
                Phone1 = "7777",
                Email = "lakers@gmail.com",
                Address1 = "QC"
            };

            context.Customers.Add(customer3);
            context.SaveChanges();

            ///PRODUCT
            var product1 = new Product()
            {
                Name = "Samsung",
                UnitPrice = 999.99m
            };

            context.Products.Add(product1);
            context.SaveChanges();

            var product2 = new Product()
            {
                Name = "Nokia",
                UnitPrice = 4000.99m
            };

            context.Products.Add(product2);
            context.SaveChanges();

            var product3 = new Product()
            {
                Name = "IPhone",
                UnitPrice = 999.99m
            };

            context.Products.Add(product3);
            context.SaveChanges();
        }
    }
}
