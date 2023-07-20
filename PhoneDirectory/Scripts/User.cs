using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace PhoneDirectory.Scripts
{
    public class User
    {
        private string _name;
        private string _surname;
        private string _phoneNumber;
        private string _email;
        private string _address;
        private string _password;
        private string _role;
        private string _username;

        private UsefulUtilities util = new UsefulUtilities();
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

        #region Getters and Setters
        // GET/SET password
        public string Password
        {
            get { return _password; }
            set 
            { 

                _password = value;
                _password = util.EncryptPassword(_password);
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string Mail
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        #endregion

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

                command.Parameters.AddWithValue("@name", this.Name);
                command.Parameters.AddWithValue("@surname", this.Surname);
                command.Parameters.AddWithValue("@gsmNum", this.PhoneNumber);
                command.Parameters.AddWithValue("@email", this.Mail);
                command.Parameters.AddWithValue("@address", this.Address);
                command.Parameters.AddWithValue("@password", this.Password);
                command.Parameters.AddWithValue("@role", this.Role);
                command.Parameters.AddWithValue("@username", this.Username);

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

            newPassword = util.EncryptPassword(newPassword);

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

        public User LoginVerify(string email, string password)
        {
            SqlConnection conn = connection.GetConnection();
            User user = new User();

            string encrypted = util.EncryptPassword(password);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("VerifyUnamePwd", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", encrypted);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    user.Name = reader["firstName"]?.ToString() ?? string.Empty;
                    user.Surname = reader["lastName"]?.ToString() ?? string.Empty;
                    user.PhoneNumber = reader["gsmNumber"]?.ToString() ?? string.Empty;
                    user.Mail = reader["email"]?.ToString() ?? string.Empty;
                    user.Address = reader["address"]?.ToString() ?? string.Empty;
                    user.Username = reader["username"]?.ToString() ?? string.Empty;
                    user.Role = reader["role"]?.ToString() ?? string.Empty;
                    user._password = reader["password"]?.ToString() ?? string.Empty;
                }


            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
            finally
            {
                conn.Close();
            }

            return user;

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
                    user.Name = reader["firstName"]?.ToString() ?? string.Empty;
                    user.Surname = reader["lastName"]?.ToString() ?? string.Empty;
                    user.PhoneNumber = reader["gsmNumber"]?.ToString() ?? string.Empty;
                    user.Mail = reader["email"]?.ToString() ?? string.Empty;
                    user.Address = reader["address"]?.ToString() ?? string.Empty;
                    user.Username = reader["username"]?.ToString() ?? string.Empty;
                    user.Role = reader["role"]?.ToString() ?? string.Empty;
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

            Password = password;
            return password;
        }

    }

    
}
