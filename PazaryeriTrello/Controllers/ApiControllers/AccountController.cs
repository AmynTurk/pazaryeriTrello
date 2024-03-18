using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PazaryeriTrello.Interfaces;
using PazaryeriTrello.Models;
using PazaryeriTrello.Models.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazaryeriTrello.Controllers.ApiControllers
{
    [Route("api/Account/{action}")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public IActionResult Login(LoginRequest request)
        {
            return Ok(_accountService.Login(request));
        }
    }
}
