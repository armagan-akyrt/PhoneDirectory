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

        public User()
        {

        }

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

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("CreateUser", conn);
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
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        public List<User> RetrieveUsersList(string searchWord)
        {
            SqlConnection conn = connection.GetConnection();
            List<User> users = new List<User>();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("RetrieveUsers", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@userSearch", searchWord);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User();
                    user._name = reader["firstName"].ToString();
                    user._surname = reader["lastName"].ToString();
                    user._phoneNumber = reader["gsmNumber"].ToString();
                    user._email = reader["email"].ToString();
                    user._address = reader["address"].ToString();
                    user._username = reader["username"].ToString();
                    user._role = reader["role"].ToString();
                    users.Add(user);
                }

            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                conn.Close();
            }

            return users;
        }

        // TODO : deleting user causes permenant loss in data instead of soft delete
        public bool DeleteUser(string deletedBy)
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("RemoveUser", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@username", this._username);
                command.Parameters.AddWithValue("@deletedBy", deletedBy);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        public bool SoftDeleteUser()
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SoftDeleteFromUsers", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@username", this._username);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                
                return false;
                throw;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

    }

    
}
