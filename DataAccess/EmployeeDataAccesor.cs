using System.Collections.Generic;
using System.Data.SqlClient;
using PayRollSystem.Models;

namespace DataAccess
{
    public class EmployeeDataAccessor
    {
        private SqlConnection sqlConnection;

        public void Save(Employee employee)
        {
            OpenConnection();

            var query =
                string.Format(
                    "Insert into Employee(EmployeeCode,EmployeeName,Address,PostCode,Salary) values ('{0}','{1}','{2}','{3}',{4})", employee.EmployeeCode, employee.EmployeeName, employee.Address,
                    employee.PostCode, employee.Salary);

            var sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            ClosConnection();
        }

        public List<Employee> LoadAll()
        {
            OpenConnection();

            var query =
                string.Format("select * from employee");

            var sqlCommand = new SqlCommand(query, sqlConnection);
            var reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                var o = reader;
            }

            ClosConnection();

            return new List<Employee>();
        }

        private void ClosConnection()
        {
            sqlConnection.Close();
        }

        private void OpenConnection()
        {
            sqlConnection = new SqlConnection(@"Server=localhost;Integrated Security=True;" + "Database=PayRollSystem");
            sqlConnection.Open();
        }
    }
}
