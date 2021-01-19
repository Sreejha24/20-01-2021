using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EmployeeDAL;

namespace EmployeeBAL
{
    public class ReadEmployees
    {
        public List<Employee> searchEmp(string searchBy,string  searchValue)
        {
            DataTable table = new DataTable(); 
               table= new GetEmployees().SearchEmployees(searchBy, searchValue);
            List<Employee> emp = new List<Employee>();
            foreach(DataRow item in table.Rows)
            {
                emp.Add(new Employee()
                {
                    EmpId = int.Parse(item["EmpId"].ToString()),
                    EmpName = item["EmpName"].ToString(),
                    City = item["City"].ToString(),
                    Salary = decimal.Parse(item["Salary"].ToString()),
                    DeptId = int.Parse(item["DeptId"].ToString())

                })  ;
            }
            return emp;
        }
    }
}
