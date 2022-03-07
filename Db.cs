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
            connectionString = $"Server=localhost;Database=Company;User Id=sa;Password=Warstroy21!;";
        }

        public object USP_CreateDepartment(string Dname, string MgrSSN)
        {
            connection = new SqlConnection(connectionString);

            string sql = $"EXECUTE usp_CreateDepartment '{Dname}', {MgrSSN};";

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                int identity = Convert.ToInt32(command.ExecuteScalar());
                command.Dispose();
                connection.Close();
                return identity;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
