using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazaryeriTrello.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        [Route("Account/Login")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
