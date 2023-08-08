using PhoneDirectory.Scripts;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneDirectory
{
    public partial class AddNewRoom : Form
    {
        private UsefulUtilities util = new UsefulUtilities();
        private List<User> users = new List<User>();
        private User selectedUser = new User();
        public AddNewRoom()
        {
            InitializeComponent();
        }

        private void AddNewRoom_Load(object sender, EventArgs e)
        {
            users = util.PrintUsersList("", UsersList, users, true);
        }

        private void UsersSearchBar_TextChanged(object sender, EventArgs e)
        {
            string searchWord = UsersSearchBar.Text;
            searchWord = util.ConvertInputToAscii(searchWord);

            users = util.PrintUsersList(searchWord, UsersList, users, true);
        }

        private void UsersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = UsersList.SelectedIndex;
            if (selectedIndex < 0)
            {
                return;
            }

            selectedUser = users[selectedIndex];
            UserFirstNamePropmt.Text = selectedUser.Name;
            UserLastNamePrompt.Text = selectedUser.Surname;
            UserEmailPrompt.Text = selectedUser.Mail;
            UserGsmPrompt.Text = selectedUser.PhoneNumber;
            UserRoleBox.Text = selectedUser.Role;
            UserAddressPrompt.Text = selectedUser.Address;

        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            ConferenceRoom conferenceRoom = new ConferenceRoom();

            conferenceRoom.RoomCapacity = Convert.ToInt32(RoomCapacityPrompt.Text);
            conferenceRoom.OverseerId = selectedUser.Id;

            if (conferenceRoom.CreateConferenceRoom())
            {
                MessageBox.Show("Yeni oda başarıyla oluşturuldu.");
                return;
            }

            MessageBox.Show("Oda oluşturulurken bir hata oluştu.");
        }
    }
}
