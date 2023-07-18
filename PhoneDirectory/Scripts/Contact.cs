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
        // TODO : create procedure to insert conact
        public bool CreateContact(User associatedUser)
        {
            SqlConnection conn = connection.GetConnection();
            conn.Open();

            SqlCommand command = new SqlCommand("prCreateContact", conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@name", this._name);
            command.Parameters.AddWithValue("@surname", this._surname);
            command.Parameters.AddWithValue("@gsmNum", this._phoneNumber);
            command.Parameters.AddWithValue("@email", this._email);
            command.Parameters.AddWithValue("@address", this._address);
            //command.Parameters.AddWithValue("@username", this._username);
            command.Parameters.AddWithValue("@userUserName", associatedUser._username);

            command.ExecuteNonQuery();

            conn.Close();

            return true;
        }

        // TODO : check if retrieve is successful
        public List<Contact> RetrieveContact(string checkName)
        {

            List<Contact> contacts = new List<Contact>();

            SqlConnection conn = connection.GetConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM contacts WHERE username LIKE '%' + @username + '%'", conn);
                command.Parameters.AddWithValue("@username", checkName);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Contact contact = new Contact();

                    contact._phoneNumber = (reader["phone_number"].ToString() is null) ? " " : reader["phone_number"].ToString();
                    contact._email = (reader["email"].ToString() is null) ? " " : reader["email"].ToString();
                    contact._address = (reader["address"].ToString() is null) ? " " : reader["address"].ToString();
                    contact._username = (reader["username"].ToString() is null) ? " " : reader["username"].ToString();
                    contact._name = (reader["name"].ToString() is null) ? " " : reader["name"].ToString();
                    contact._surname = (reader["surname"].ToString() is null) ? " " : reader["surname"].ToString();

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


    }

    
}
