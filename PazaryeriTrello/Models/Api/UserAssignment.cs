using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazaryeriTrello.Models.Api
{
    public class UserAssignment
    {
    }

    public class GetUsersTasksResponse : ResponseBase
    {
        public List<UserAssignmentDTO> Data { get; set; }
    }

    public class UserAssignmentDTO 
    {
        public string TaskText { get; set; }
        public int Statue { get; set; }
    }
}
