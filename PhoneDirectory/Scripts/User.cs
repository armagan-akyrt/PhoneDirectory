using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PhoneDirectory.Scripts
{
    public class User
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

        public bool ChangePassword(string newPassword, string oldPassword)
        {

            if (!_password.Equals(oldPassword))
            {
                return false;
            }

            SqlConnection conn = connection.GetConnection();

            try
            {

                conn.Open();

                SqlCommand command = new SqlCommand("ChangePassword", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@username", this._username);
                command.Parameters.AddWithValue("@password", newPassword);

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

        public bool UpdateUser(string oldUsername)
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("UpdateUser", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@name", this._name);
                command.Parameters.AddWithValue("@surname", this._surname);
                command.Parameters.AddWithValue("@gsmNum", this._phoneNumber);
                command.Parameters.AddWithValue("@email", this._email);
                command.Parameters.AddWithValue("@address", this._address);
                command.Parameters.AddWithValue("@password", this._password);
                command.Parameters.AddWithValue("@role", this._role);
                command.Parameters.AddWithValue("@username", this._username);
                command.Parameters.AddWithValue("@oldUsername", oldUsername);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
                throw;
            }

            return true;
        }

        public List<User> RetrieveUsersList(string searchWord, bool activeState)
        {
            SqlConnection conn = connection.GetConnection();
            List<User> users = new List<User>();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("RetrieveUsers", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@userSearch", searchWord);
                command.Parameters.AddWithValue("@activeState", activeState);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User();
                    user._name = reader["firstName"]?.ToString() ?? string.Empty;
                    user._surname = reader["lastName"]?.ToString() ?? string.Empty;
                    user._phoneNumber = reader["gsmNumber"]?.ToString() ?? string.Empty;
                    user._email = reader["email"]?.ToString() ?? string.Empty;
                    user._address = reader["address"]?.ToString() ?? string.Empty;
                    user._username = reader["username"]?.ToString() ?? string.Empty;
                    user._role = reader["role"]?.ToString() ?? string.Empty;
                    user._password = reader["password"]?.ToString() ?? string.Empty;
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
        public bool DeleteUser()
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("RemoveUser", conn);
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

        public bool BringBackDeletedUser()
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("RetrieveDeletedUser", conn);
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


        /// <summary>
        /// generates a random password for the user. Includes upper case, lower case and numbers.
        /// </summary>
        /// <returns>password</returns>
        public string GenerateRandomPassword()
        {
            Random random = new Random();
            string password = "";
            for (int i = 0; i < 8; i++)
            {
                int chance = random.Next(0, 100);
                if (chance < 20) // for upper case characters.
                {
                    int randomChar = random.Next(65, 91);
                    char character = (char)randomChar;
                    password += character.ToString();
                }
                else if (chance < 80) // for lower case characters.
                {
                    int randomChar = random.Next(97, 123);
                    char character = (char)randomChar;
                    password += character.ToString();
                }
 
                else // for numbers.
                {
                    int randomInt = random.Next(0, 9);
                    password += randomInt.ToString();
                }

            }

            this._password = password;
            return password;
        }

    }

    
}
