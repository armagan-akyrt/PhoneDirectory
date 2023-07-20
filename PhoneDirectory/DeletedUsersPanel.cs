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

        private User currentUser = new User();
        string selectedUsername = "";


        public DeletedUsersPanel(User user)
        {
            InitializeComponent();

            this.currentUser = user;
            this.username = this.currentUser.Username;
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

                FirstNamePrompt.Text = deletedUsers[selectedIndex].Name;
                LastNamePrompt.Text = deletedUsers[selectedIndex].Surname;
                GsmPrompt.Text = deletedUsers[selectedIndex].PhoneNumber;
                EmailPrompt.Text = deletedUsers[selectedIndex].Mail;
                AddressPrompt.Text = deletedUsers[selectedIndex].Address;

                user = deletedUsers[selectedIndex];
                selectedUsername = user.Username;

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
