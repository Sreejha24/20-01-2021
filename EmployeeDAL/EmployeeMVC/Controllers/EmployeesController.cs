using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeMVC.Data;
using EmployeeMVC.Models;
using EmployeeBAL;
using System.Data;
using Microsoft.AspNetCore.Http;


namespace EmployeeMVC.Controllers
{
    public class EmployeesController : Controller
    {
       

        // GET: Employees

        public IActionResult Search()
        {
            return View(new List<Employee>());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Search(IFormCollection form)
        {
            var fieldName = form["FieldName"].ToString();
            var keyword = form["Keyword"].ToString();

            List<Employee> employees = new List<Employee>();
        employees =  new ReadEmployees().searchEmp(fieldName, keyword);
            return View(employees);
          

        }
       
    
        }

        

      
    }

