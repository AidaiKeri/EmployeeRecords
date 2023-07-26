using EmployeeRecordsSystem.Models;
using EmployeeRecordsSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeRecordsSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeManagement _employeeManagement;

        public HomeController(EmployeeManagement employeeManagement)
        {
            _employeeManagement = employeeManagement;
        }

        public IActionResult Index()
        {
            var employees = _employeeManagement.GetAllEmployees();
            return View(employees);
        }

        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeManagement.AddEmployee(employee);
                return RedirectToAction(nameof(Index));
            }

            return View(employee);
        }

        public IActionResult RemoveEmployee(int id)
        {
            _employeeManagement.RemoveEmployee(id);
            return RedirectToAction(nameof(Index));
        }
    }
}