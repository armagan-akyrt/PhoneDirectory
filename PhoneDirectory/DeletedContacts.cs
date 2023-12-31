﻿using PhoneDirectory.Scripts;

namespace PhoneDirectory
{
    public partial class DeletedContacts : Form
    {

        private User user = new User();

        public string username; // current user's username
        private string role; // current user's role

        private List<Contact> deletedContacts = new List<Contact>();
        private Contact contact = new Contact();
        private string selectedUsername = "";

        private bool isAdmin = false;

        private UsefulUtilities util = new UsefulUtilities();

        public DeletedContacts(User user, bool isFromAdminScreen)
        {
            InitializeComponent();

            this.user = user;

            this.username = user.Username;
            this.role = user.Role;
            this.isAdmin = isFromAdminScreen;
        }

        private void DeletedContacts_Load(object sender, EventArgs e)
        {
            deletedContacts = util.PrintContactsList("", DeletedContactsList, deletedContacts, user.Id, false);



        }

        private void ContactsSearchBar_TextChanged(object sender, EventArgs e)
        {
            string input = ContactsSearchBar.Text;
            input = util.ConvertInputToAscii(input);

            deletedContacts = util.PrintContactsList(input, DeletedContactsList, deletedContacts, user.Id, false);
        }

        private void DeletedContactsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = DeletedContactsList.SelectedIndex;

            try
            {
                if (selectedIndex >= 0)
                {
                    FirstNamePrompt.Text = deletedContacts[selectedIndex]._name;
                    LastNamePrompt.Text = deletedContacts[selectedIndex]._surname;
                    GsmPrompt.Text = deletedContacts[selectedIndex]._phoneNumber;
                    EmailPrompt.Text = deletedContacts[selectedIndex]._email;
                    AddressPrompt.Text = deletedContacts[selectedIndex]._address;

                    contact = deletedContacts[selectedIndex];
                    selectedUsername = contact._username;
                }
            }
            catch (Exception)
            {
                return;
            }

        }

        private void DeletePermenantlyButton_Click(object sender, EventArgs e)
        {
            
            contact.CutUserContact(user.Id);

            deletedContacts = util.PrintContactsList("", DeletedContactsList, deletedContacts, user.Id, false);
        }

        private void UpdateAndBringButton_Click(object sender, EventArgs e)
        {
            contact.UpdateContact(selectedUsername);
            if (contact.BringBackDeletedUser())
            {
                MessageBox.Show("Kullanıcı başarıyla geri getirildi.");
            }
            else
            {
                MessageBox.Show("Kullanıcı geri getirilemedi.");
            }

            deletedContacts = util.PrintContactsList("", DeletedContactsList, deletedContacts, user.Id, false);
        }
    }
}
