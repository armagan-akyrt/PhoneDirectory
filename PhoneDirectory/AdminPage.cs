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
        private List<User> users = new List<User>();
        private List<Contact> contacts = new List<Contact>();
        private UsefulUtilities util = new UsefulUtilities();


        private string selectedUser = ""; // selected user's username from the list


        public AdminPage(string username)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.username = username;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSearchUsers_TextChanged(object sender, EventArgs e)
        {
            // user searcbar string, converted to lowercase and without spaces
            string search = (UsersSearchBar.Text).ToLower().Replace(" ", "");
            search = util.ConvertInputToAscii(search);

            // retrieve users list
            User user = new User();
            users = user.RetrieveUsersList(search);

            util.PrintUsersList(search, UsersList, users);

        }



        private void txtSearchContacts_TextChanged(object sender, EventArgs e)
        {
            // contact searchbar string, converted to lowercase and without spaces
            string search = (ContactsSearchBar.Text).ToLower().Replace(" ", "");
            search = util.ConvertInputToAscii(search);
            util.PrintContactsList(search, ContactsList, contacts, selectedUser);

        }

        private void UserViewStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage(username);
            userPage.Show();
            this.Hide();
        }

        private void lsUsersList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBringContacts_Click(object sender, EventArgs e)
        {

            Contact contact = new Contact();
            selectedUser = UsersList.SelectedItem.ToString().Replace(" ", "").ToLower();
            selectedUser = util.ConvertInputToAscii(selectedUser);
            ContactsList.Items.Clear();

            // retrieve contacts list
            string contactSearch = ContactsSearchBar.Text.ToLower().Replace(" ", "");
            contactSearch = util.ConvertInputToAscii(contactSearch);

            List<Contact> contacts = contact.RetrieveContact(contactSearch, selectedUser);
            util.PrintContactsList(contactSearch, ContactsList, contacts, selectedUser);
        }

        private void NewUserMenuStrip_Click(object sender, EventArgs e)
        {
            Form createUser = new CreateUser(username);
            createUser.Show();
            this.Hide();
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {

            users[UsersList.SelectedIndex].SoftDeleteUser();
        }

        private void DeletedUsersToolStrip_Click(object sender, EventArgs e)
        {

        }
    }
}
