using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Employee.Models;

namespace Employee.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Employee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Employee(Employee1 employees )
        {

            try
            {
                Employee1 em = new Employee1();
                em.Name = employees.Name;
                em.Designation = employees.Designation;
                em.Code = employees.Code;
                em.Address = employees.Address;
                new DatabaseHandler().EmployeeMethod(em);
                TempData["message"] = "Your data has been saved";

                return RedirectToAction("Employee", "Employee", null);


            }
            catch (Exception)
            {

                throw;
            }
           

        }
    }
}