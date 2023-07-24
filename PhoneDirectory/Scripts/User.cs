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
        private int _id;

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
        public string Password
        {
            get { return _password; }
            set 
            { 

                _password = value;
                _password = util.EncryptPassword(_password);
            }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
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

        /// <summary>
        /// Creates a new user in the database
        /// </summary>
        /// <returns>true if successful</returns>
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

        /// <summary>
        /// changes the password of the user
        /// </summary>
        /// <param name="newPassword"> password to change</param>
        /// <param name="oldPassword"> previous password for another check</param>
        /// <returns>true is successful</returns>
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

        /// <summary>
        /// Updates the user information in the database
        /// </summary>
        /// <param name="oldUsername"></param>
        /// <returns>true if successful</returns>
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

        /// <summary>
        /// Verifies the email and password for login
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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
                    user.Id = Convert.ToInt32(reader["id"]?.ToString() ?? string.Empty);
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

        /// <summary>
        /// Retrieves the user list from the database
        /// </summary>
        /// <param name="searchWord">part of username to search</param>
        /// <param name="activeState">current state 0=> soft deleted, 1=> active</param>
        /// <returns>a list of users with specified params</returns>
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
                    user.Id = Convert.ToInt32(reader["id"]?.ToString() ?? string.Empty);
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

        /// <summary>
        /// Permanent delete from database
        /// </summary>
        /// <returns>true if succesful</returns>
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

        /// <summary>
        /// Soft delete user from database
        /// </summary>
        /// <returns>true if successful</returns>
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

        /// <summary>
        /// Brings back the soft deleted user from database
        /// </summary>
        /// <returns>true if succesful</returns>
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
