using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace PhoneDirectory.Scripts
{

    internal class Contact
    {
        #region Data Fields
        public string _name;
        public string _surname;
        public string _phoneNumber;
        public string _email;
        public string _address;
        public string _username;
        #endregion

        private Connection connection = new Connection();

        public Contact()
        {
           _name = ""; _surname = ""; _phoneNumber = ""; _email = ""; _address = ""; _username = "";
        }
        public Contact(string name, string surname, string phoneNumber, string mail, string address, string username)
        {
            this._name = name;
            this._surname = surname;
            this._phoneNumber = phoneNumber;
            this._email = mail;
            this._address = address;
            this._username = username;
        }

        

        // TODO : check if user exists
        // TODO : remove any special characters from username
        /// <summary>
        /// creates a new contact with the associated user
        /// </summary>
        /// <param name="associatedUser"></param>
        /// <returns></returns>
        public bool CreateContact(string associatedUser)
        {
            SqlConnection conn = connection.GetConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("CreateContact", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@name", this._name);
                command.Parameters.AddWithValue("@surname", this._surname);
                command.Parameters.AddWithValue("@gsmNum", this._phoneNumber);
                command.Parameters.AddWithValue("@email", this._email);
                command.Parameters.AddWithValue("@address", this._address);
                command.Parameters.AddWithValue("@username", this._username);
                command.Parameters.AddWithValue("@userUserName", associatedUser);

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

        // TODO : check if retrieve is successful
        /// <summary>
        /// retrieves contact information from database
        /// </summary>
        /// <param name="checkName"></param>
        /// <param name="userUsername"></param>
        /// <returns></returns>
        public List<Contact> RetrieveContact(string checkName, string userUsername, bool isActive)
        {

            List<Contact> contacts = new List<Contact>();

            SqlConnection conn = connection.GetConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("RetrieveData", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@contactSearch", checkName);
                command.Parameters.AddWithValue("@userUsername", userUsername);
                command.Parameters.AddWithValue("@activeState", isActive);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Contact contact = new Contact();

                    contact._phoneNumber = (reader["gsmNumber"].ToString() is null) ? " " : reader["gsmNumber"].ToString();
                    contact._email = (reader["email"].ToString() is null) ? " " : reader["email"].ToString();
                    contact._address = (reader["address"].ToString() is null) ? " " : reader["address"].ToString();
                    contact._username = (reader["username"].ToString() is null) ? " " : reader["username"].ToString();
                    contact._name = (reader["firstName"].ToString() is null) ? " " : reader["firstName"].ToString();
                    contact._surname = (reader["lastName"].ToString() is null) ? " " : reader["lastName"].ToString();

                    contacts.Add(contact);
                }

                
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return contacts;
        }

        /// <summary>
        /// updates current contact with new information
        /// </summary>
        /// <param name="oldUserName"> previously used username</param>
        /// <returns>true if successful</returns>
        public bool UpdateContact(string oldUserName)
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("UpdateContact", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@name", this._name);
                command.Parameters.AddWithValue("@surname", this._surname);
                command.Parameters.AddWithValue("@gsmNum", this._phoneNumber);
                command.Parameters.AddWithValue("@email", this._email);
                command.Parameters.AddWithValue("@address", this._address);
                command.Parameters.AddWithValue("@oldUsername", oldUserName);

                command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
    
        public bool DeleteContact(string deletedBy)
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("RemoveContact", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@username", this._username);
                command.Parameters.AddWithValue("@deletedBy", deletedBy);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        public bool SoftDeleteContact()
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SoftDeleteFromContacts", conn);
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
