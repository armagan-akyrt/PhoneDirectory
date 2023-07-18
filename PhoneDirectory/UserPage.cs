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
        private string oldGsm = "";

        public string username;
        public UserPage(string username)
        {
            InitializeComponent();
            this.username = username;
        }



        private void UserPage_Load(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contacts = contact.RetrieveContact("", username);
        }
        /// <summary>
        /// converts turkish string into ascii string
        /// </summary>
        /// <param name="input"> input string of any size.</param>
        /// <returns>converted string</returns>
        private string ConvertInputToAscii(string input)
        {
            // contains lowercase turkish characters
            var charMap = new Dictionary<char, char>()
            {
                {'ç', 'c'},
                {'ğ', 'g'},
                {'ı', 'i'},
                {'ö', 'o'},
                {'ş', 's'},
                {'ü', 'u'}
            };

            foreach (KeyValuePair<char, char> entry in charMap)
            {
                input = input.Replace(entry.Key, entry.Value);
            }

            return input;
        }
        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            string input = SearchBar.Text.ToLower().Replace(" ", "");
            input = ConvertInputToAscii(input);

            contacts = contact.RetrieveContact(input, username);
            ContactsListBox.Items.Clear();
            foreach (Contact res in contacts)
            {
                string tagToWrite = "FIRST LAST".Replace("FIRST", res._name).Replace("LAST", res._surname);
                ContactsListBox.Items.Add(tagToWrite);
            }
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string uname = "";
            try
            {
                uname = ContactsListBox.Items[ContactsListBox.SelectedIndex].ToString().Replace(" ", "").ToLower();
                uname = ConvertInputToAscii(uname);
            }
            catch (Exception)
            {

                return;
            }


            Contact contactToShow = contacts.Find(x => x._username == uname);
            oldGsm = contactToShow._phoneNumber;

            NamePrompt.Text = contactToShow._name;
            SurnamePromp.Text = contactToShow._surname;
            EmailPrompt.Text = contactToShow._email;
            GsmPrompt.Text = contactToShow._phoneNumber;
            AddresPrompt.Text = contactToShow._address;

        }

        private void UpdatePerson_Click(object sender, EventArgs e)
        {
            GsmPrompt.Text = GsmPrompt.Text.Replace(" ", "");

            string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            string gsmPattern = @"^(\+90|0)?(5\d{2})(\d{7})$";
            Regex rgx = new Regex(emailPattern);
            bool isEmailValid = rgx.IsMatch(EmailPrompt.Text);

            rgx = new Regex(gsmPattern);
            bool isGsmValid = rgx.IsMatch(GsmPrompt.Text);

            if (!isEmailValid)
            {
                MessageBox.Show("E-posta geçerli değil!");
                return;
            }
            if (!isGsmValid)
            {
                MessageBox.Show("GSM numarası geçerli değil!");
                return;
            }

            Connection connection = new Connection();
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("prUpdateContact", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@name", NamePrompt.Text);
                command.Parameters.AddWithValue("@surname", SurnamePromp.Text);
                command.Parameters.AddWithValue("@gsmNum", GsmPrompt.Text);
                command.Parameters.AddWithValue("@email", EmailPrompt.Text);
                command.Parameters.AddWithValue("@address", AddresPrompt.Text);
                command.Parameters.AddWithValue("@oldGsmNum", oldGsm);

                command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            Contact contact = new Contact();
            contacts = contact.RetrieveContact("", username);


        }
    }
}
