using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            return View(GetCustomers());
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(cust => cust.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer { Id = 1, Name = "Oscar"},
                new Customer { Id = 2, Name = "Pedro"}
            };
        }
    }
}