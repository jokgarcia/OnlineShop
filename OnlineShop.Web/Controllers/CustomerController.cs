using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Web.Models;
using OnlineShop.Web.Repository;
using OnlineShop.Web.ViewModels;

namespace OnlineShop.Web.Controllers
{
    public class CustomerController : Controller
    {
        IOnlineShopRepository onlineShopRepository;

        //Constructoe
        public CustomerController(IOnlineShopRepository _onlineShopRepository)
        {
            onlineShopRepository = _onlineShopRepository;
        }

        // GET: CustomerController
        public IActionResult Index()
        {
            var viewModel = new CustomerViewModel();
            var customers = onlineShopRepository.GetCustomers();
            viewModel.CustomerList = customers;

            return View(viewModel);
        }
        // GET: CustomerController/Edit/5
        public IActionResult Edit(int Id, string FirstName, string LastName,string Email,string Phone1 )
        {
            //ViewBag / ViewData
            ViewData["Id"] = Id;
            ViewData["FirstName"] = FirstName;
            ViewData["LastName"] = LastName;
            ViewData["Email"] = Email;
            ViewData["PhoneNumber"] = Phone1;

            return View();
        }
        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Customer customer)
        {
            try
            {
                if (ModelState.IsValid) 
                {
                    onlineShopRepository.UpdateCustomer(customer);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
    }
}
