using System.Collections.Generic;
using CommonLayer.Models;
using ManagerLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EmployeeMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public readonly IEmployeeManager manager;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(IEmployeeManager manager, ILogger<EmployeeController> _logger)
        {
            this.manager = manager;
            this._logger = _logger;
        }
        public IActionResult GetAllEmployee()
        {
            List<EmployeeModel> lstEmployee = new List<EmployeeModel>();
            lstEmployee = manager.GetAllEmployee();

            return View(lstEmployee);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee([Bind] AddEmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                manager.AddEmployee(employee);
                
                return RedirectToAction("GetAllEmployee");
            }
            return View(employee);
        }

        [HttpGet]
        public IActionResult GetDataById(int id)
        {
            HttpContext.Session.GetInt32("EmployeeId");
            if (id == 0)
            {
                return NotFound();
            }
            
            EmployeeModel employee = manager.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }


        [HttpGet]
        public IActionResult UpdateEmployee(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            EmployeeModel employee = manager.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        
        public IActionResult UpdateEmployee(int id, [Bind] EmployeeModel employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                manager.UpdateEmployee(employee);
                return RedirectToAction("GetAllEmployee");
            }
            return View(employee);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            EmployeeModel employee = manager.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        
        public IActionResult Delete(int? id)
        {
            manager.DeleteEmployee(id);
            return RedirectToAction("GetAllEmployee");
        }


        [HttpGet]
        public IActionResult Login(int id,string name)
        {
            if (id == 0 && name==null)
            {
                return NotFound();
            }
            EmployeeModel employee = manager.Login(id,name);
            HttpContext.Session.SetInt32("EmployeeId", id);
            HttpContext.Session.SetString("EmployeeName", employee.EmployeeName);
            if (employee == null)
            {
                return NotFound();
            }
            //return View(employee);
            return RedirectToAction("GetDataById");
        }

        [HttpGet]
        public IActionResult GetEmployee(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            EmployeeModel emp = manager.GetEmployeeById(id);
            if (emp == null)
            {
                return BadRequest(new ResponseModel { Success = true, Message = "id does not exist" });

            }
            return RedirectToAction("GetDataById");
        }

        [HttpPut]
        public IActionResult GetEmpByIdAndUpdateData(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            
            if (id == 0)
            {
                RedirectToAction("AddEmployee");
                return Ok(new ResponseModel { Success = true, Message = "id does not exist so create a new profile." });
                
            }
            else
            {
                EmployeeModel emp = manager.GetEmployeeById(id);
                RedirectToAction("UpdateEmployee");
                return Ok(new ResponseModel { Success = true, Message = "id exist,you can update your profile." });


            }
        }

    }
}
