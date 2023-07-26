using EmployeeRecordsSystem.Models;
using EmployeeRecordsSystem.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


//namespace EmployeeRecordsSystem.Controllers

//{
//    public class EmployeeController : Controller
//    {
//        private readonly EmployeeManagement employeeManagement;

//        public EmployeeController()
//        {
//            employeeManagement = new EmployeeManagement();
//        }

//        public IActionResult Index()
//        {
//            var employees = employeeManagement.GetAllEmployees();
//            return View(employees);
//        }

//        [HttpGet]
//        public IActionResult AddEmployee()
//        {
//            return View();
//        }

//        [HttpPost("AddEmployee")]
//        public IActionResult AddEmployee(Employee employee)
//        {
//            if (ModelState.IsValid)
//            {
//                employeeManagement.AddEmployee(employee);
//                return RedirectToAction("Index");
//            }

//            return View(employee);
//        }

//        [HttpGet]
//        public IActionResult RemoveEmployee()
//        {
//            return View();
//        }

//        [HttpPost("RemoveEmployee")]
//        public IActionResult RemoveEmployee(int id)
//        {
//            employeeManagement.RemoveEmployee(id);
//            return RedirectToAction("Index");
//        }
//    }
//}