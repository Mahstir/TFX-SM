using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FX.Models;
using FX.Models.Viewmodels;
using Microsoft.AspNet.Identity;

namespace FX.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult CustomerForm()
        {
            var plans = _context.Plans.ToList();

            var viewModel = new CustomerFormViewModel()
            {
                Plans = plans
            };

            return View(viewModel);
        }

        public ActionResult Index()
        {
            var customers = _context.Customers.ToList();

            return View();
        }

        public ActionResult Save(Customer customer)
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {

                    
                    Customer = customer,
                    Plans = _context.Plans.ToList()
                    
                };

                return View("CustomerForm", viewModel);
            }

            if (customer.Id == 0)
            {
                customer.UserId = User.Identity.GetUserId();
                customer.DateOfpayment = DateTime.Today;
                customer.Email = User.Identity.Name;
                
              


                if (customer.PlanId == 1)
                {
                    customer.DateOfReturn = customer.DateOfpayment.Value.AddDays(12);
                    customer.Amount = (300 * 0.24) + 300;
                }
                   

                else if (customer.PlanId == 2)
                {
                    customer.DateOfReturn = customer.DateOfpayment.Value.AddDays(5);
                    customer.Amount = (500 * 1) + 500;
                }

                else if (customer.PlanId == 3)
                {
                    customer.DateOfReturn = customer.DateOfpayment.Value.AddDays(5);
                    customer.Amount = (500 * 2) + 500;

                }

                else if (customer.PlanId == 4)
                {
                    customer.DateOfReturn = customer.DateOfpayment.Value.AddDays(10);
                    customer.Amount = (200 * 2) + 200;

                }
            }

            

            _context.Customers.Add(customer);
            _context.SaveChanges();

            return RedirectToAction("Invest", "Account");
        }
    }
}