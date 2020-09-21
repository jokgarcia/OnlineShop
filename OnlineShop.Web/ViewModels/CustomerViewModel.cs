using OnlineShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.ViewModels
{
    public class CustomerViewModel
    {
        public IEnumerable<Customer> CustomerList { get; set; }
    }
}
