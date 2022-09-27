using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Crm_UILayer.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
        public IActionResult Index()
        {
            var values = employeeManager.TGetListAll        ();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            employeeManager.TInsert(employee);
            return RedirectToAction("Index");
        }
    }
}
