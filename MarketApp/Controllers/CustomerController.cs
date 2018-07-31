using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarketApp.Models;

namespace MarketApp.Controllers
{
    [Route("api/NorthWind/Customer")]
    public class CustomerController : Controller
    {

        [HttpGet()]
        public IActionResult Index()
        {
            NORTHWNDContext northWindcontext = new NORTHWNDContext();


            var jsonCustomerDetail = northWindcontext.Customers.ToList();

            return new JsonResult(jsonCustomerDetail);
        }
    }
}