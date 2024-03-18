using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazaryeriTrello.Models.Entities
{
    public class UserAssignment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AssignmentId { get; set; }
        public int StatueId { get; set; }
        public bool IsActive { get; set; }
    }
}
