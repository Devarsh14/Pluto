using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JquerywithNorthWinds.Models;

namespace JquerywithNorthWinds.Controllers
{
    public class CustomerController : Controller
    {
        
        // GET: Customer
        public ActionResult Index()
        {
            var Dbcontext = new NorthWindDbContext();
            var customer = Dbcontext.Customers
                .OrderBy(c => c.City);

            return View(customer);
        }
    }
}