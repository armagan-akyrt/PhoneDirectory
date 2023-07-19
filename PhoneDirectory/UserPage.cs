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
        private UsefulUtilities util = new UsefulUtilities();

        private List<Contact> contacts = new List<Contact>();
        private string oldUsername = "";

        public string username;
        public UserPage(string username)
        {
            InitializeComponent();
            this.username = username;
        }



        private void UserPage_Load(object sender, EventArgs e)
        {
            util.PrintContactsList("", ContactsListBox, contacts, username);

        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            string input = SearchBar.Text.ToLower().Replace(" ", "");
            input = util.ConvertInputToAscii(input);

            util.PrintContactsList(input, ContactsListBox, contacts, username);


        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string uname = " ";
            try
            {
                uname = ContactsListBox.Items[ContactsListBox.SelectedIndex].ToString().Replace(" ", "").ToLower();
                uname = util.ConvertInputToAscii(uname);
            }
            catch (Exception)
            {

                return;
            }


            Contact contactToShow = contacts.Find(x => x._username == uname);
            oldUsername = contactToShow._username;

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
            int i = ContactsListBox.SelectedIndex;

            contacts[i]._name = NamePrompt.Text;
            contacts[i]._surname = SurnamePromp.Text;
            contacts[i]._email = EmailPrompt.Text;
            contacts[i]._phoneNumber = GsmPrompt.Text;
            contacts[i]._address = AddresPrompt.Text;

            contacts[i].UpdateContact(oldUsername);

            util.PrintContactsList("", ContactsListBox, contacts, username);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            contacts[ContactsListBox.SelectedIndex].SoftDeleteContact();
            util.PrintContactsList("", ContactsListBox, contacts, username);
        }

        private void AddPersonToolStrip_Click(object sender, EventArgs e)
        {
            Form FormAddContact = new AddContact(username);
            FormAddContact.Show();
            this.Hide();
        }

        
    }
}
