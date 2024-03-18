using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PazaryeriTrello.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazaryeriTrello.Controllers.ApiControllers
{
    [Authorize]
    [Route("api/Task")]
    public class UserAssignmentController : Controller
    {
        private readonly IUserAssignmentService _userAssignmentService;

        public UserAssignmentController(IUserAssignmentService userAssignmentService)
        {
            _userAssignmentService = userAssignmentService;
        }

        [HttpGet("GetUsersTasks")]
        public IActionResult GetUsersTasks(int UserId)
        {
            return Ok(_userAssignmentService.GetUsersTasks(UserId));
        }
    }
}
