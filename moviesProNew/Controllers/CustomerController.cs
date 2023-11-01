using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using moviesProNew.Models;

namespace moviesProNew.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customer = GetCustomers();
            return View(customer);
        }
        public ActionResult Details(int id)
        {
            var cus = GetCustomers().SingleOrDefault(c=> c.Id == id);   
            return View(cus);
        }

        private List<Customer> GetCustomers()
        {
           return new List<Customer> 
            {
                new Customer(){Id= 1, CName="Yash"},
                new Customer(){Id=2, CName="Ravi"},
                new Customer(){Id=999, CName="Miral"}
            };        }
    }
}