using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarketApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MarketApp.Controllers
{
    public class HomeController : Controller
    {
          
        public IActionResult Index()
        {
            var dbcontex = new Dev_MarketContext();
            var list = dbcontex.MarketWatch22002018.ToList();

            return View(list);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
