using DatabaseLayer;
using Microsoft.Extensions.Configuration;
using RepositoryLayer.EmployeePayrollContext;
using RepositoryLayer.Entity;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryLayer.Services
{
    public class EmployeeRL:IEmployeeRL
    {
        EmployeePayrollContext1 empl;
        public IConfiguration Configuration { get; }
        public EmployeeRL(EmployeePayrollContext1 empl, IConfiguration Configuration)
        {
            this.empl = empl;
            this.Configuration = Configuration;
        }

        public Employee AddEmployee(EmployeeModel employee)
        {
            try
            {
                Employee emp = new Employee();
                emp.EmployeeId = new Employee().EmployeeId;
                emp.EmployeeName = employee.EmployeeName;
                emp.Salary = employee.Salary;
                emp.ProfileImage = employee.ProfileImage;
                emp.StartDate = employee.StartDate;
                emp.Department = employee.Department;
                emp.Gender = employee.Gender;
                empl.Employees.Add(emp);
                empl.SaveChanges();
                return emp;
            }
            catch (Exception ex)
            {
               throw ex;
            }
           
        }

        public Employee UpdateEmployee(EmployeeModel model,int EmployeeId)
        {
            try
            {
                var res = empl.Employees.FirstOrDefault(u => u.EmployeeId == EmployeeId);
                if (res != null)
                {

                    res.EmployeeName = model.EmployeeName;
                    res.ProfileImage = model.ProfileImage;
                    res.StartDate = model.StartDate;
                    res.Department = model.Department;
                    res.Gender = model.Gender;
                    res.Salary = model.Salary;
                    empl.SaveChanges();

                    return empl.Employees.Where(a => a.EmployeeId == EmployeeId).FirstOrDefault();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public bool DeleteEmployee(int EmployeeId)
        {
            try
            {
                var res = empl.Employees.FirstOrDefault(u => u.EmployeeId == EmployeeId);
                if(res != null)
                {
                    empl.Employees.Remove(res);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Employee GetEmployeeById(int EmployeeId)
        {
            try
            {
                var res = empl.Employees.FirstOrDefault(u => u.EmployeeId == EmployeeId);
                if( res != null)
                {
                    return res;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Employee> GetAllEmployee()
        {
            try
            {
                List<Employee> employees = empl.Employees.ToList();
                return employees;
            }
            catch (Exception ex)
            {
                 throw ex;
            }
            
            
        }
    }
}
