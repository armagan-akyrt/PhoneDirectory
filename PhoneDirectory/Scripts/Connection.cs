using System.Data.SqlClient;


namespace PhoneDirectory.Scripts
{

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
