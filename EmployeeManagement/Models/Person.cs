using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Person
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Address { get; set; }

        public char Gender { get; set; } = 'M';

        public double Salary { get; set; }
    }
}
