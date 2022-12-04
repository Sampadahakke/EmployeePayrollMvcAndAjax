using BusinessLayer.Interfaces;
using DatabaseLayer;
using RepositoryLayer.Entity;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class EmployeeBL : IEmployeeBL
    {
        private readonly IEmployeeRL employeeRL;

        public EmployeeBL(IEmployeeRL employeeRL)
        {
           this.employeeRL = employeeRL;
        }
        public Employee AddEmployee(EmployeeModel employee)
        {
            try
            {
                return employeeRL.AddEmployee(employee);
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
                return this.employeeRL.DeleteEmployee(EmployeeId);
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
                return this.employeeRL.GetAllEmployee();
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
                return this.employeeRL.GetEmployeeById(EmployeeId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Employee UpdateEmployee(EmployeeModel model, int EmployeeId)
        {
            try
            {
                return this.employeeRL.UpdateEmployee(model, EmployeeId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
