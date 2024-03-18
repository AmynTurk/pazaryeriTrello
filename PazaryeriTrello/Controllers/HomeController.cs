using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazaryeriTrello.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home/Index")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
