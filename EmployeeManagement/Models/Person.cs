using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Person
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="This field is required")]
        [Display(Name = "First Name")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        public string Address { get; set; }

        public char? Gender { get; set; } = 'M';

        public double? Salary { get; set; }
        
        public static List<Person> GetEmployees()
        {
            //object initializer syntax
            Person emp1 = new Person() { Firstname = "Saugat", Lastname = "Tiwari", Address = "KTM", Salary = 20000.0 };
            Person emp2 = new Person() { Firstname = "Saurav", Lastname = "Dangol", Address = "KTM", Salary = 20000.0 };
            Person emp3 = new Person() { Firstname = "Anil", Lastname = "Bikram Thapa", Address = "KTM", Salary = 45000.0 };
            Person emp4 = new Person() { Firstname = "Safal", Lastname = "Mahat", Address = "KTM", Salary = 45000.0 };
            Person emp5 = new Person() { Firstname = "Ram", Lastname = "Kadel", Address = "Janakpur", Salary = 20500.0 };
            Person emp6 = new Person() { Firstname = "Hari", Lastname = "Gautam", Address = "Pokhara", Salary = 15000.0 };

            List<Person> employees = new List<Person>() { emp1, emp2, emp3, emp4, emp5, emp6 };

            return employees;
        }
    }
}
