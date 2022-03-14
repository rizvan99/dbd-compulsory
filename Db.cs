using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBD_Compulsory
{
    public class Db
    {
        private string connectionString;
        SqlConnection connection;
        SqlCommand command;

        public Db()
        {
            connectionString = $"Server=localhost;Database=Company;Integrated Security=SSPI;";
        }

        public object USP_CreateDepartment(string Dname, string MgrSSN)
        {
            connection = new SqlConnection(connectionString);

            string sql = $"EXECUTE usp_CreateDepartment '{Dname}', {MgrSSN};";

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                int identity = Convert.ToInt32(command.ExecuteScalar());
                command.Dispose();
                connection.Close();
                return identity;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void USP_UpdateDepartmentName(int DNumber, string DName)
        {
            connection = new SqlConnection(connectionString);

            string sql = $"EXECUTE usp_UpdateDepartmentName {DNumber}, '{DName}';";

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void USP_UpdateDepartmentManager(int DNumber, string MgrSSN)
        {
            connection = new SqlConnection(connectionString);

            string sql = $"EXECUTE usp_UpdateDepartmentManager {DNumber}, '{MgrSSN}';";

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void usp_DeleteDepartment(int DNumber)
        {
            connection = new SqlConnection(connectionString);

            string sql = $"EXECUTE usp_DeleteDepartment {DNumber};";

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void usp_GetDepartment(int DNumber)
        {
            connection = new SqlConnection(connectionString);

            string sql = $"EXECUTE usp_GetDepartmentV2 {DNumber};";

            try
            {
                using (SqlConnection connection = new SqlConnection(
                           connectionString))
                {
                    SqlCommand command = new SqlCommand(
                        sql, connection);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(String.Format("{0}, {1}, {2}, {3}",
                                reader[0], reader[1], reader[2], reader[3]));
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void usp_GetAllDepartments()
        {
            connection = new SqlConnection(connectionString);

            string sql = $"EXECUTE usp_GetAllDepartmentsV2;";

            try
            {
                using (SqlConnection connection = new SqlConnection(
                           connectionString))
                {
                    SqlCommand command = new SqlCommand(
                        sql, connection);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(String.Format("{0}, {1}, {2}",
                                reader[0], reader[1], reader[2]));
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
