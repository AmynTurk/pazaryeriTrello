using Microsoft.EntityFrameworkCore;
using PazaryeriTrello.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazaryeriTrello.Models.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Assignment> Assignment { get; set; }
        public DbSet<AssignStatus> AssignStatus { get; set; }
        public DbSet<UserAssignment> UserAssignment { get; set; }
    }
}
