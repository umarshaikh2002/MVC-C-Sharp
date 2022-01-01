using EmployeeManagment.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagment.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.FirstName = "Umar";
            List<Employee> employees = new List<Employee>();
            employees.AddRange(new List<Employee> {
               new Employee {
                   Id = 1,
                   Name = "Umar",
                   Salary = 80000
               },
               new Employee {
                   Id = 2,
                   Name = "Wasim",
                   Salary = 670000
               },
               new Employee {
                   Id = 3,
                   Name = "Hamid",
                   Salary = 60000
               }
           });



            return View(employees);
        }

        public IActionResult Details(string name, float sal)
        {
            ViewBag.name = name;
            ViewBag.sal = sal;

            return View();
        }

        public IActionResult GetName(string empName)
        {
            TempData["empName"] = empName;

            int zero = 0;

            try
            {
                int result = 10 / zero;
            }
            catch
            {
                return View("/Views/Shared/Error.cshtml");
            }

            return RedirectToAction("Index");
        }
    }
}
