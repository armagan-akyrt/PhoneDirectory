using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace PhoneDirectory.Scripts
{

    public class Contact
    {
        #region Data Fields
        public string _name;
        public string _surname;
        public string _phoneNumber;
        public string _email;
        public string _address;
        public string _username;
        public int _id;
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
            this._id = 0;
        }
        

        /// <summary>
        /// creates a new contact with the associated user
        /// </summary>
        /// <param name="associatedUser">the user who created this contact</param>
        /// <returns>true on success</returns>
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

        /// <summary>
        /// retrieves contact information from database
        /// </summary>
        /// <param name="checkName">searchword for contacts.</param>
        /// <param name="userUsername">associated user username</param>
        /// <returns>list of contacts associeated with user.</returns>
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

                    contact._phoneNumber = (reader["gsmNumber"]?.ToString()?? string.Empty);
                    contact._email = (reader["email"]?.ToString() ?? string.Empty);
                    contact._address = (reader["address"]?.ToString() ?? string.Empty);
                    contact._username = (reader["username"]?.ToString() ?? string.Empty);
                    contact._name = (reader["firstName"]?.ToString() ?? string.Empty);
                    contact._surname = (reader["lastName"]?.ToString() ?? string.Empty);
                    contact._id = Convert.ToInt32(reader["id"]?.ToString() ?? string.Empty);

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
    
        /// <summary>
        /// Deletes contact from database permenantly
        /// </summary>
        /// <returns>true if successful</returns>
        public bool DeleteContact()
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("RemoveContact", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@username", this._username);

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

        /// <summary>
        /// Soft deletes contact from database
        /// </summary>
        /// <returns>true if successful</returns>
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

        /// <summary>
        /// Retrieves soft deleted contact from database
        /// </summary>
        /// <returns>true if successful</returns>
        public bool BringBackDeletedUser()
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                
                SqlCommand command = new SqlCommand("RetrieveDeletedContact", conn);
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
        /// Severes contact from user
        /// </summary>
        /// <param name="username">associated user</param>
        /// <returns>true if successful.</returns>
        public bool CutUserContact(string username)
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SevereUserContact", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@userUsername", username);
                command.Parameters.AddWithValue("@contactUsername", this._username);

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
