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
    public partial class AddConference : Form
    {
        private User currentUser;
        private List<User> users = new List<User>();
        private UsefulUtilities util = new UsefulUtilities();
        private List<int> participantIds;

        private User selectedUser = new User();
        bool isSelectVaild = false;

        private List<ConferenceRoom> conferenceRooms = new();

        public struct ShortendRoom
        {
            public int roomId;
            public int roomCapacity;
            public string roomPrompt;
        }
        

        public AddConference(User user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        private void AddConference_Load(object sender, EventArgs e)
        {
            users = util.PrintUsersList("", UsersListBox, users, true);
            conferenceRooms = new ConferenceRoom().GetConferenceRooms();
            foreach (ConferenceRoom room in conferenceRooms)
            {
                string roomPrompt = "Oda #ROOM_ID - ROOM_CAPACITY Kişilik".Replace("ROOM_ID", room.RoomId.ToString()).Replace("ROOM_CAPACITY", room.RoomCapacity.ToString());
                
                ShortendRoom shortendRoom = new ShortendRoom();
                shortendRoom.roomId = room.RoomId;
                shortendRoom.roomCapacity = room.RoomCapacity;
                shortendRoom.roomPrompt = roomPrompt;

                ConferenceRoomSelection.Items.Add(shortendRoom);

                
            }
        }

        private void UsersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = UsersListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                isSelectVaild = false;
                return;
            }

            selectedUser = users[selectedIndex];
            UserFirstNamePropmt.Text = selectedUser.Name;
            UserLastNamePrompt.Text = selectedUser.Surname;
            UserEmailPrompt.Text = selectedUser.Mail;
            UserGsmPrompt.Text = selectedUser.PhoneNumber;
            UserAddressPrompt.Text = selectedUser.Address;
            isSelectVaild = true;


        }

        private void UserSearchBar_TextChanged(object sender, EventArgs e)
        {
            string searchWord = UserSearchBar.Text;
            searchWord = util.ConvertInputToAscii(searchWord);

            users = util.PrintUsersList(searchWord, UsersListBox, users, true);
        }

        private void AddParticipant_Click(object sender, EventArgs e)
        {
            if (isSelectVaild)
            {
                if (participantIds.Contains(selectedUser.Id))
                {
                    MessageBox.Show("Kullanıcı ZZaten Toplantı Listesinde Bulunmakta.");
                    return;
                }
                participantIds.Add(selectedUser.Id);
            }
        }

        private void CreateRequestButton_Click(object sender, EventArgs e)
        {

        }
    }
}
