using System;
using System.Collections.Generic;
using System.Text;
using CommonLayer.Models;
using ManagerLayer.Interfaces;
using RepositoryLayer.Interfaces;

namespace ManagerLayer.Services
{
    public class EmployeeManager:IEmployeeManager
    {
        private readonly IEmployeeRepository iemployee;
        
        public EmployeeManager(IEmployeeRepository employee)
        {
            this.iemployee = employee;

        }
        public bool AddEmployee(AddEmployeeModel model)
        {
            return iemployee.AddEmployee(model);
        }
        public EmployeeModel GetEmployeeById(int EmployeeId)
        {
            return iemployee.GetEmployeeById(EmployeeId);
        }
        public List<EmployeeModel> GetAllEmployee()
        {
            return iemployee.GetAllEmployee();
        }

        public bool UpdateEmployee(EmployeeModel employee)
        {
            return iemployee.UpdateEmployee(employee);
        }
        public bool DeleteEmployee(int? id)
        {
            return iemployee.DeleteEmployee(id);
        }
        public EmployeeModel Login(int employeeId, string employeeName)
        {
            return iemployee.Login(employeeId, employeeName);
        }

        
    }
}
