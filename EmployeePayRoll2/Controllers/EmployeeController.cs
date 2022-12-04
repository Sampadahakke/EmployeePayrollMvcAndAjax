using BusinessLayer.Interfaces;
using DatabaseLayer;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Entity;
using System.Collections.Generic;
using System.Linq;

namespace EmployeePayRoll2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeBL employeeBL;
        public EmployeeController(IEmployeeBL employeeBL)
        {
            this.employeeBL = employeeBL;
        }

       public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetAllEmployees()
        {
            List<Employee> employeelist = this.employeeBL.GetAllEmployee();
            return Json(employeelist);
            
        }
       
        public JsonResult GetEmployeeById(int EmployeeId)
        {
            Employee employee = this.employeeBL.GetEmployeeById(EmployeeId);
           
            return Json(employee);
        }

        public JsonResult AddEmployee(EmployeeModel model)
        {
            Employee employee =new Employee();
            employee = this.employeeBL.AddEmployee(model);
            return Json(employee);
        }
       
        public JsonResult UpdateEmployee(EmployeeModel model,int EmployeeId)
        {
            Employee employee = new Employee();
            employee = this.employeeBL.UpdateEmployee(model,EmployeeId);
            return Json(employee);
        }

        public JsonResult DeleteEmployee(int EmployeeId)
        {
            var res=this.employeeBL.DeleteEmployee(EmployeeId);
            return Json(res);
        }
    }
}
