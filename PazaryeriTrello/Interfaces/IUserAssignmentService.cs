using PazaryeriTrello.Models.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazaryeriTrello.Interfaces
{
    public interface IUserAssignmentService
    {
        public GetUsersTasksResponse GetUsersTasks(int UserId);
    }
}
