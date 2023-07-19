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
    public partial class DeletedUsersPanel : Form
    {
        public string username; // current user's username
        private UsefulUtilities util = new UsefulUtilities();

        private List<User> deletedUsers = new List<User>();
        private User user = new User();
        string selectedUsername = "";


        public DeletedUsersPanel(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void DeletedUsersPanel_Load(object sender, EventArgs e)
        {

            deletedUsers = util.PrintUsersList("", DeletedUsersList, deletedUsers, false);
        }

        private void DeletedUsersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = DeletedUsersList.SelectedIndex;

            if (selectedIndex >= 0)
            {
                // write the selected user's info to the textboxes

                FirstNamePrompt.Text = deletedUsers[selectedIndex]._name;
                LastNamePrompt.Text = deletedUsers[selectedIndex]._surname;
                GsmPrompt.Text = deletedUsers[selectedIndex]._phoneNumber;
                EmailPrompt.Text = deletedUsers[selectedIndex]._email;
                AddressPrompt.Text = deletedUsers[selectedIndex]._address;

                user = deletedUsers[selectedIndex];
                selectedUsername = user._username;

            }
        }

        private void UpdateAndBringButton_Click(object sender, EventArgs e)
        {

            user.UpdateUser(selectedUsername);

            user.BringBackDeletedUser();
            deletedUsers = util.PrintUsersList("", DeletedUsersList, deletedUsers, false);

        }

        private void DeletePermenantlyButton_Click(object sender, EventArgs e)
        {
            user.DeleteUser();
            deletedUsers = util.PrintUsersList("", DeletedUsersList, deletedUsers, false);
        }

        private void UsersSearchBar_TextChanged(object sender, EventArgs e)
        {
            string input = UsersSearchBar.Text;
            input = util.ConvertInputToAscii(input);

            deletedUsers = util.PrintUsersList(input, DeletedUsersList, deletedUsers, false);
        }
    }
}
