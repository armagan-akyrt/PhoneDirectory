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

    public partial class AdminPage : Form
    {
        public string username; // current user's username
        private string role; // current user's role

        private List<User> users = new List<User>();
        private List<Contact> contacts = new List<Contact>();
        private UsefulUtilities util = new UsefulUtilities();

        private User currentUser = new User();

        private string selectedUser = ""; // selected user's username from the list


        public AdminPage(User user)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            currentUser = user;

            this.username = currentUser.Username;
            this.role = currentUser.Role;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            users = util.PrintUsersList("", UsersList, users, true);

        }

        private void txtSearchUsers_TextChanged(object sender, EventArgs e)
        {
            // user searcbar string, converted to lowercase and without spaces
            string search = UsersSearchBar.Text;
            search = util.ConvertInputToAscii(search);

            // retrieve users list
            User user = new User();
            users = user.RetrieveUsersList(search, false);

            users = util.PrintUsersList(search, UsersList, users, true);

        }



        private void txtSearchContacts_TextChanged(object sender, EventArgs e)
        {
            // contact searchbar string, converted to lowercase and without spaces
            string search = (ContactsSearchBar.Text);
            search = util.ConvertInputToAscii(search);
            contacts = util.PrintContactsList(search, ContactsList, contacts, selectedUser, true);

        }

        private void UserViewStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage(currentUser);
            userPage.Show();
            this.Hide();
        }

        private void lsUsersList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBringContacts_Click(object sender, EventArgs e)
        {
            if (UsersList.SelectedIndex == -1 || UsersList.SelectedItems == null)
            {
                return;
            }

            Contact contact = new Contact();
            selectedUser = UsersList.SelectedItem.ToString();
            selectedUser = util.ConvertInputToAscii(selectedUser);
            ContactsList.Items.Clear();

            // retrieve contacts list
            string contactSearch = ContactsSearchBar.Text;
            contactSearch = util.ConvertInputToAscii(contactSearch);

            contacts = util.PrintContactsList(contactSearch, ContactsList, contacts, selectedUser, true);
        }

        private void NewUserMenuStrip_Click(object sender, EventArgs e)
        {
            Form createUser = new CreateUser(username);
            createUser.ShowDialog();
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {

            users[UsersList.SelectedIndex].SoftDeleteUser();
        }

        private void DeletedUsersToolStrip_Click(object sender, EventArgs e)
        {
            Form deletedUsers = new DeletedUsersPanel(currentUser);
            deletedUsers.ShowDialog();
        }

        private void DeletedContactsToolStrip_Click(object sender, EventArgs e)
        {
            Form deletedContacts = new DeletedContacts(currentUser);
            deletedContacts.ShowDialog();
        }

        private void NewContactToolstrip_Click(object sender, EventArgs e)
        {
            Form addContact = new AddContact(currentUser);
            addContact.ShowDialog();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ContactsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ContactsList.SelectedIndex;
            if (selectedIndex != -1)
            {
                Contact selectedContact = contacts[selectedIndex];
                NamePrompt.Text = selectedContact._name;
                LastNamePrompt.Text = selectedContact._surname;
                GsmPrompt.Text = selectedContact._phoneNumber;
                EmailPrompt.Text = selectedContact._email;
                AddressPrompt.Text = selectedContact._address;
            }
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {

        }
    }
}
