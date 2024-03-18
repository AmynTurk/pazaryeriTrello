using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazaryeriTrello.Models.Entities
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Code { get; set; }
    }
}
