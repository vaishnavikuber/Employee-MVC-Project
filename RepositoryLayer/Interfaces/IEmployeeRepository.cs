using System;
using System.Collections.Generic;
using System.Text;
using CommonLayer.Models;

namespace RepositoryLayer.Interfaces
{
    public interface IEmployeeRepository

    {
        public bool AddEmployee(AddEmployeeModel model);
        public EmployeeModel GetEmployeeById(int EmployeeId);
        public List<EmployeeModel> GetAllEmployee();
        public bool UpdateEmployee(EmployeeModel employee);
        public bool DeleteEmployee(int? id);
        public EmployeeModel Login(int employeeId, string employeeName);
    }
}
