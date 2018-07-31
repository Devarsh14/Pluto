using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarketApp.Models;


namespace MarketApp.Controllers
{

    [Route("api/MarketWatch/ShareDetails")]
    public class MarketWatchController : Controller
    {
        [HttpGet()]
        public IActionResult GetShareDetails()
        {
            Dev_MarketContext context = new Dev_MarketContext();
            var jsonresult=context.MarketWatch22002018.ToList();

            return new JsonResult(jsonresult);
        }

        [HttpGet("{id}")]
        public IActionResult GetShareCompany(string id)
        {
            Dev_MarketContext context = new Dev_MarketContext();
            var jsonresult = context.MarketWatch22002018.ToList();

            var t=jsonresult.FirstOrDefault(c => c.SecurityCode==id);

            if(t==null)
            {
                return NotFound();
            }
            return Ok(t);

        }

    }
}