using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace PhoneDirectory.Scripts
{
    //private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PhoneDirectory;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    internal class Connection
    {
        public SqlConnection GetConnection()
        {
            string connectionString = "Server=.;Database=PhoneDirectory; Integrated Security=SSPI";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;

        }


    }
}
