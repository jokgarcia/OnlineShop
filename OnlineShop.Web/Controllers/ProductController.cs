using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            //Changes
            return View();
        }
    }
}
