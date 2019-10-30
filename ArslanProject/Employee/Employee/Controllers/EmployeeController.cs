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
                return RedirectToAction("manage") ;
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpGet]
        public IActionResult Manage()
        {
            var listofalldataindb = new DatabaseHandler().GetAllList();
            return View(listofalldataindb);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
           var getrowdata= new DatabaseHandler().GetRow(id);
            return View(getrowdata);
        }
        [HttpPost]
        public IActionResult Edit(Employee1 Em)
        {
            new DatabaseHandler().updateemp(Em);
            TempData["Msg"] = "Your record have been Updated";
            return RedirectToAction("manage");
        }
        public IActionResult Delete(int id)
        {
            var getrowdata = new DatabaseHandler().GetRow(id);
            new DatabaseHandler().Deleteemp(getrowdata);
            TempData["Msgdd"] = "Your record have been Deleted";
            return RedirectToAction("manage");


        }
    }


}