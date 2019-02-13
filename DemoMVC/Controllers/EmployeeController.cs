using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            ViewBag.Title = "Employee Page";

            Employee employee = new Employee()
            {
                EmployeeId = 1,
                Name = "Sany Yousif",
                City = "Nashville"
            };

        //incase we use the strongly typed models we don't need ViewBag or ViewData
            // ViewBag.EmpDetails = "empId: " + employee.EmployeeId + " Name: " + employee.Name + " City: " + employee.City;
            //ViewBag.EmpDetails = employee;
            //return View();

        //incase we didn't use ViewBage to pass the data from the controller to the view 
        //we should pass the employee object to the view like this return view(employee) 
            return View(employee);
        }
    }
}