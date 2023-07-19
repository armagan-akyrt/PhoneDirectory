using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneDirectory.Scripts;
namespace PhoneDirectory
{
    public partial class DeletedContacts : Form
    {
        public string username; // current user's username

        private List<Contact> deletedContacts = new List<Contact>();
        private Contact contact = new Contact();
        private string selectedUsername = "";

        private UsefulUtilities util = new UsefulUtilities();

        public DeletedContacts(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void DeletedContacts_Load(object sender, EventArgs e)
        {
            deletedContacts = util.PrintContactsList("", DeletedContactsList, deletedContacts, username, false);
        }

        private void ContactsSearchBar_TextChanged(object sender, EventArgs e)
        {
            string input = ContactsSearchBar.Text;
            input = util.ConvertInputToAscii(input);

            deletedContacts = util.PrintContactsList(input, DeletedContactsList, deletedContacts, username, false);
        }

        private void DeletedContactsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = DeletedContactsList.SelectedIndex;

            FirstNamePrompt.Text = deletedContacts[selectedIndex]._name;
            LastNamePrompt.Text = deletedContacts[selectedIndex]._surname;
            GsmPrompt.Text = deletedContacts[selectedIndex]._phoneNumber;
            EmailPrompt.Text = deletedContacts[selectedIndex]._email;
            AddressPrompt.Text = deletedContacts[selectedIndex]._address;

            contact = deletedContacts[selectedIndex];
            selectedUsername = contact._username;

        }

        private void DeletePermenantlyButton_Click(object sender, EventArgs e)
        {
            contact.DeleteContact();

            deletedContacts = util.PrintContactsList("", DeletedContactsList, deletedContacts, username, false);
        }

        private void UpdateAndBringButton_Click(object sender, EventArgs e)
        {
            contact.UpdateContact(selectedUsername);
            contact.BringBackDeletedUser();

            deletedContacts = util.PrintContactsList("", DeletedContactsList, deletedContacts, username, false);
        }
    }
}
