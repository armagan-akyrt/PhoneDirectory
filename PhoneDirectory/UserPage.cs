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

        private User user = new User();
        private UsefulUtilities util = new UsefulUtilities();

        

        private List<Contact> contacts = new List<Contact>();
        private string oldUsername = "";

        public string username;
        private string role;
        public UserPage(User user)
        {
            InitializeComponent();
            this.user = user;

            this.username = user.Username;
            this.role = user.Role;
            // make this page not changable to other open forms

        }



        private void UserPage_Load(object sender, EventArgs e)
        {
            contacts = util.PrintContactsList("", ContactsListBox, contacts, username, true);

            if (role.Equals("ADMIN"))
            {
                AdminToolStrip.Visible = true;
            }
            else
            {
                AdminToolStrip.Visible = false;
            }


        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            string input = SearchBar.Text;
            input = util.ConvertInputToAscii(input);

            contacts = util.PrintContactsList(input, ContactsListBox, contacts, username, true);


        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string uname = " ";
            try
            {
                uname = ContactsListBox.Items[ContactsListBox.SelectedIndex].ToString();
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

            int i = ContactsListBox.SelectedIndex;

            contacts[i]._name = NamePrompt.Text;
            contacts[i]._surname = SurnamePromp.Text;
            contacts[i]._email = EmailPrompt.Text;
            contacts[i]._phoneNumber = GsmPrompt.Text;
            contacts[i]._address = AddresPrompt.Text;

            contacts[i].UpdateContact(oldUsername);

            contacts = util.PrintContactsList("", ContactsListBox, contacts, username, true);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            contacts[ContactsListBox.SelectedIndex].SoftDeleteContact();
            contacts = util.PrintContactsList("", ContactsListBox, contacts, username, true);
        }

        private void AddPersonToolStrip_Click(object sender, EventArgs e)
        {
            Form FormAddContact = new AddContact(user);
            FormAddContact.ShowDialog();
        }

        private void AdminToolStripMenu_Click(object sender, EventArgs e)
        {
            Form AdminPage = new AdminPage(user);
            AdminPage.ShowDialog();
        }

        private void DeletedContactsToolStrip_Click(object sender, EventArgs e)
        {
            Form DeletedContacts = new DeletedContacts(user);
            DeletedContacts.Show();
            this.Hide();
        }

        private void ChangePasswordStripTool_Click(object sender, EventArgs e)
        {
            Form ChangePwd = new ChangePassword(user);
            ChangePwd.ShowDialog();
        }
    }
}
