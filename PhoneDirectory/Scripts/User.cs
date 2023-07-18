using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PhoneDirectory.Scripts
{
    internal class User
    {
        public string _name;
        public string _surname;
        public string _phoneNumber;
        public string _email;
        public string _address;
        public string _password;
        public string _role;
        public string _username;

        Connection connection = new Connection();

        public User(string name, string surname, string phoneNumber, string mail, string address, string pwd, string role) {
            this._name = name;
            this._surname = surname;
            this._phoneNumber = phoneNumber;
            this._email = mail;
            this._address = address;
            this._password = pwd;
            this._role = role;

            this._username = this._name.ToLower() + this._surname.ToLower();

        }

        // TODO : check if user exists
        // TODO : remove any special characters from username
        public bool CreateUser()
        {
            SqlConnection conn = connection.GetConnection();

            conn.Open();
            SqlCommand command = new SqlCommand("prCreateUser", conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@name", this._name);
            command.Parameters.AddWithValue("@surname", this._surname);
            command.Parameters.AddWithValue("@gsmNum", this._phoneNumber);
            command.Parameters.AddWithValue("@email", this._email);
            command.Parameters.AddWithValue("@address", this._address);
            command.Parameters.AddWithValue("@password", this._password);
            command.Parameters.AddWithValue("@role", this._role);
            command.Parameters.AddWithValue("@username", this._username);

            command.ExecuteNonQuery();

            // TODO: check if user is created successfully
            
            conn.Close();

            return true;
        }

        

    }

    
}
