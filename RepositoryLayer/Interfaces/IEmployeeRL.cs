﻿using DatabaseLayer;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interfaces
{
    public interface IEmployeeRL
    {
        Employee AddEmployee(EmployeeModel employee);
        Employee UpdateEmployee(EmployeeModel model, int EmployeeId);
        bool DeleteEmployee(int EmployeeId);
        Employee GetEmployeeById(int EmployeeId);
        List<Employee> GetAllEmployee();
    }
}
