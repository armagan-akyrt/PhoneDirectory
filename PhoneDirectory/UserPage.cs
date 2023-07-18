using PhoneDirectory.Scripts;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhoneDirectory
{
    public partial class UserPage : Form
    {
        private List<Contact> contacts = new List<Contact>();

        public UserPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            string input = txtSearchBar.Text.ToLower();
            contacts = contact.RetrieveContact(txtSearchBar.Text);
            lbContacts.Items.Clear();
            foreach (Contact res in contacts)
            {
                string tagToWrite = "USERNAME, FIRST LAST".Replace("USERNAME", res._username).Replace("FIRST", res._name).Replace("LAST", res._surname);
                lbContacts.Items.Add(tagToWrite);
            }
        }

        private void lbContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string uname = lbContacts.Items[lbContacts.SelectedIndex].ToString();

            string pattern = @"(\w+),";

            Regex rgx = new Regex(pattern);
            Match match = rgx.Match(uname);
            uname = match.Groups[1].Value;

            Contact contactToShow = contacts.Find(x => x._username == uname);

            txtName.Text = contactToShow._name;
            txtSurname.Text = contactToShow._surname;
            txtEmail.Text = contactToShow._email;
            txtGsm.Text = contactToShow._phoneNumber;
            rtAdress.Text = contactToShow._address;

        }

        private void txtUpdatePerson_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlConnection conn = connection.GetConnection();

            try 
            { 
                conn.Open();
                SqlCommand command = new SqlCommand("prUpdateContact", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@name", txtName.Text);
                command.Parameters.AddWithValue("@surname", txtSurname.Text);
                command.Parameters.AddWithValue("@gsmNum", txtGsm.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@address", rtAdress.Text);

                command.ExecuteNonQuery();
            
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }
    }
}
