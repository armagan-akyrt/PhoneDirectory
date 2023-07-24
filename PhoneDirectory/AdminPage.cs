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
        private User user = new User();

        private List<Contact> contacts = new List<Contact>();


        private UsefulUtilities util = new UsefulUtilities();

        private User currentUser = new User();

        private string selectedUser = ""; // selected user's username from the list
        private string contactUsername = ""; // selected contact's name from the list


        public AdminPage(User user)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            currentUser = user;
            this.user = user;

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

            int selectedIndex = UsersList.SelectedIndex;

            user = users[selectedIndex];

            UserFirstNamePropmt.Text = users[selectedIndex].Name;
            UserLastNamePrompt.Text = users[selectedIndex].Surname;
            UserEmailPrompt.Text = users[selectedIndex].Mail;
            UserGsmPrompt.Text = users[selectedIndex].PhoneNumber;
            UserAddressPrompt.Text = users[selectedIndex].Address;
            UserRoleBox.SelectedItem = users[selectedIndex].Role.Equals("ADMIN") ? "ADMIN" : "USER";

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
            Form deletedContacts = new DeletedContacts(user, true);
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
            try
            {
                if (selectedIndex != -1)
                {
                    this.contactUsername = contacts[selectedIndex]._username;
                    Contact selectedContact = contacts[selectedIndex];
                    NamePrompt.Text = selectedContact._name;
                    LastNamePrompt.Text = selectedContact._surname;
                    GsmPrompt.Text = selectedContact._phoneNumber;
                    EmailPrompt.Text = selectedContact._email;
                    AddressPrompt.Text = selectedContact._address;

                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void UpdateContactButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ContactsList.SelectedIndex;
            try
            {
                if (selectedIndex != -1)
                {
                    Contact currentContact = contacts[selectedIndex];
                    currentContact._name = NamePrompt.Text;
                    currentContact._surname = LastNamePrompt.Text;
                    currentContact._phoneNumber = GsmPrompt.Text;
                    currentContact._email = EmailPrompt.Text;
                    currentContact._address = AddressPrompt.Text;

                    currentContact.UpdateContact(contactUsername);
                }
            }
            catch (Exception)
            {
                return;
            }


        }

        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            user.Name = UserFirstNamePropmt.Text;
            user.Surname = UserLastNamePrompt.Text;
            user.Mail = UserEmailPrompt.Text;
            user.PhoneNumber = UserGsmPrompt.Text;
            user.Address = UserAddressPrompt.Text;
            user.Role = UserRoleBox.SelectedItem?.ToString()??"USER";

            user.UpdateUser(user.Username);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void misafirSayfasıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CreateGuestButton_Click(object sender, EventArgs e)
        {
            Form AddGuest = new AddGuest();
            AddGuest.ShowDialog();
        }

        private void ViewAllGuests_Click(object sender, EventArgs e)
        {
            Form AllGuests = new GuestsList(false);
            AllGuests.ShowDialog();
        }

        private void ViewGuestsInside_Click(object sender, EventArgs e)
        {
            Form InsideGuests = new GuestsList(true);
            InsideGuests.ShowDialog();
        }
    }
}
