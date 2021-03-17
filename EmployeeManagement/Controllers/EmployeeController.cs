using EmployeeManagement.Data;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private EMSContext db;
        public EmployeeController(EMSContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {


            var employees = db.Employees.ToList();
            return View(employees);
        }
        public IActionResult Detail([FromQuery] int id)
        {
            var employee = db.Employees.Find(id);
            return View(employee);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult<string> Add(Person person)
        {
            db.Employees.Add(person);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            var employee = db.Employees.Find(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            db.Employees.Attach(person);
            db.Employees.Update(person);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int id)
    {
        var employee = db.Employees.Find(id);
        
        return View(employee);
    }
    
    [HttpPost]
    public ActionResult Delete(Person person)
    {        
        db.Employees.Attach(person);
        db.Employees.Remove(person);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }


    }
}
