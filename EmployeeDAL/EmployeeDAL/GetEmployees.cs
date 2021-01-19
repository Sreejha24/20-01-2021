using System;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeDAL
{
    public class GetEmployees
    {
        string ConnStr = "Data Source=192.168.50.95;Initial Catalog=sprathipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
        public DataTable SearchEmployees(string searchBy, string searchValue)
        {
            DataTable tab = new DataTable();

            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                var sql = SQL(searchBy);
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if(searchBy=="EmpName")
                    searchValue = '%' + searchValue + '%';
                    cmd.Parameters.AddWithValue("@Emp", searchValue);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        ad.Fill(tab);

                    }
                }
            }
            return tab;
        }
        public String SQL(string searchBy)
        {
           
            var Sql = string.Empty;
            if (searchBy == "EmpId")
            {

                Sql = "Select * from Employee where Empid like @Emp";
            }
            else if (searchBy == "EmpName")
            {
                Sql = "select * from employee where EmpName Like @Emp";
            }
            return Sql;
        }
    }
}
