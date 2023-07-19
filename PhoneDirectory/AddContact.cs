using PhoneDirectory.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneDirectory
{
    public partial class AddContact : Form
    {
        public string username;
        private Connection connection = new Connection();
        public AddContact(string username)
        {
            InitializeComponent();
            this.username = username;
        }

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

        private void AddContact_Load(object sender, EventArgs e)
        {
            CurrentUserPrompt.Text = username;
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            string contactUsername = (NamePrompt.Text).ToLower().Replace(" ", "") + (SurnamePrompt.Text).ToLower().Replace(" ", "");
            contactUsername = ConvertInputToAscii(contactUsername);
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

            SqlConnection conn = connection.GetConnection();

            Contact contact = new Contact(NamePrompt.Text, SurnamePrompt.Text, GsmPrompt.Text, EmailPrompt.Text, AddressPrompt.Text, contactUsername);

            contact.CreateContact(username);

        }

        private void ReturnToUserPageButton_Click(object sender, EventArgs e)
        {
            Form userPage = new UserPage(username);
            userPage.Show();
            this.Hide();
        }

        private void RegeneratePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
