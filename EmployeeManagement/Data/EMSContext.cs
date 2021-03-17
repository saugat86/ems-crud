using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data
{
    public class EMSContext: DbContext
    {
        public EMSContext()
        {

        }
        public EMSContext(DbContextOptions<EMSContext> options) : base(options)
        {

        }


        public DbSet<Models.Person> Employees { get; set; }
    }
}
