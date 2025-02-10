using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using CommonLayer.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using RepositoryLayer.Interfaces;

namespace RepositoryLayer.Services
{
    public class EmployeeRepository:IEmployeeRepository
    {

        private readonly string _connectionString;
        private readonly IConfiguration _configuration;


        public EmployeeRepository(IConfiguration _configuration)
        {
            _connectionString = _configuration.GetConnectionString("DBConnection");
        }
        

        public bool AddEmployee(AddEmployeeModel model)
        {
            AddEmployeeModel addEmployee = new AddEmployeeModel();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("spAddEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
                command.Parameters.AddWithValue("@Email", model.Email);
                command.Parameters.AddWithValue("@Age", model.Age);
                command.Parameters.AddWithValue("@Salary", model.Salary);
                command.Parameters.AddWithValue("@City", model.City);
                command.Parameters.AddWithValue("@Department", model.Department);
                command.Parameters.AddWithValue("@Gender", model.Gender);
                connection.Open();
                var result=command.ExecuteNonQuery();
                connection.Close();
                if (result != 0)
                {
                    return true;
                }
                return false;
                         
            }
            
        }


        public EmployeeModel GetEmployeeById(int EmployeeId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
               EmployeeModel employee = new EmployeeModel();
                SqlCommand command = new SqlCommand("spGetEmployeeById",connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                connection.Open();
                
                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        employee.EmployeeId = reader.GetInt32(0);
                        employee.EmployeeName = reader.GetString(1);                      
                        employee.Email = reader.GetString(2);
                        employee.Age=reader.GetInt32(3);
                        employee.Salary=reader.GetInt32(4);
                        employee.City=reader.GetString(5);
                        employee.Department = reader.GetString(6);
                        employee.Gender = reader.GetString(7);
                    }
                    return employee;
                }
                connection.Close();
                return null;
            }
        }

        public List<EmployeeModel> GetAllEmployee()
        {
            List<EmployeeModel> employeeList = new List<EmployeeModel>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("spGetAllEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader rdr = command.ExecuteReader();
                
                while (rdr.Read())
                {
                    EmployeeModel employee = new EmployeeModel();

                    employee.EmployeeId = Convert.ToInt32(rdr["EmployeeId"]);
                    employee.EmployeeName = rdr["EmployeeName"].ToString();
                    employee.Email = rdr["Email"].ToString();
                    employee.Age = Convert.ToInt32(rdr["Age"]);
                    employee.Salary = Convert.ToInt32(rdr["Salary"]);
                    employee.City = rdr["City"].ToString();
                    employee.Department = rdr["Department"].ToString();
                    employee.Gender = rdr["Gender"].ToString();

                    employeeList.Add(employee);
                }
                connection.Close();
            }
           
            return employeeList;
        }

        public bool UpdateEmployee(EmployeeModel employee)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("spUpdateEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(@"EmployeeId", employee.EmployeeId);
                command.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                command.Parameters.AddWithValue("@Email", employee.Email);
                command.Parameters.AddWithValue("@Age", employee.Age);
                command.Parameters.AddWithValue("@Salary", employee.Salary);
                command.Parameters.AddWithValue("@City", employee.City);
                command.Parameters.AddWithValue("@Department", employee.Department);
                command.Parameters.AddWithValue("@Gender", employee.Gender);
                connection.Open();
                var result = command.ExecuteNonQuery();
                connection.Close();
                if (result != 0)
                {
                    return true;
                }
                return false;

            }
        }

        public bool DeleteEmployee(int? id)
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("spDeleteEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@EmployeeId", id);

                connection.Open();
                int res=command.ExecuteNonQuery();
                connection.Close();
                if (res != 0)
                {
                    return true;
                }
                return false;
            }
        }


        public EmployeeModel Login(int employeeId, string employeeName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("spLoginEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeId", employeeId);
                command.Parameters.AddWithValue("@EmployeeName", employeeName);
                connection.Open();

                SqlDataReader rdr = command.ExecuteReader();
                EmployeeModel employee = new EmployeeModel();
                while (rdr.Read())
                {


                    employee.EmployeeId = Convert.ToInt32(rdr["EmployeeId"]);
                    employee.EmployeeName = rdr["EmployeeName"].ToString();
                    employee.Email = rdr["Email"].ToString();
                    employee.Age = Convert.ToInt32(rdr["Age"]);
                    employee.Salary = Convert.ToInt32(rdr["Salary"]);
                    employee.City = rdr["City"].ToString();
                    employee.Department = rdr["Department"].ToString();
                    employee.Gender = rdr["Gender"].ToString();


                }
                connection.Close();
                return employee;


            }
        }


        
        



    
    }
}
