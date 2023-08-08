using PhoneDirectory.Scripts;
using System.Text.RegularExpressions;

namespace PhoneDirectory
{
    public partial class UserPage : Form
    {

        private User user = new User();
        private UsefulUtilities util = new UsefulUtilities();

        private Meeting selectedMeeting = new Meeting();
        private List<Meeting> meetings = new List<Meeting>();

        private List<Contact> contacts = new List<Contact>();
        private string oldUsername = "";

        private int selectedIndex = -1;

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
            contacts = util.PrintContactsList("", ContactsListBox, contacts, user.Id, true);
            Meeting meeting = new Meeting();
            meeting.User = user;

            meetings = util.PrintMeetingsList("", UpcomingMeetingsList, meetings, true, user, false,
                DateTime.Now.AddYears(-100), DateTime.MaxValue);
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

            contacts = util.PrintContactsList(input, ContactsListBox, contacts, user.Id, true);


        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string uname = " ";
            selectedIndex = ContactsListBox.SelectedIndex;
            try
            {

                uname = ContactsListBox.Items[selectedIndex].ToString();
                uname = util.ConvertInputToAscii(uname);

                Contact contactToShow = contacts.Find(x => x._username == uname);
                oldUsername = contactToShow._username;

                NamePrompt.Text = contactToShow._name;
                SurnamePromp.Text = contactToShow._surname;
                EmailPrompt.Text = contactToShow._email;
                GsmPrompt.Text = contactToShow._phoneNumber;
                AddresPrompt.Text = contactToShow._address;
            }
            catch (Exception)
            {

                return;
            }

        }

        private void UpdatePerson_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir bağlantı seçiniz.");
                return;
            }

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

            selectedIndex = ContactsListBox.SelectedIndex;

            contacts[selectedIndex]._name = NamePrompt.Text;
            contacts[selectedIndex]._surname = SurnamePromp.Text;
            contacts[selectedIndex]._email = EmailPrompt.Text;
            contacts[selectedIndex]._phoneNumber = GsmPrompt.Text;
            contacts[selectedIndex]._address = AddresPrompt.Text;

            contacts[selectedIndex].UpdateContact(oldUsername);

            contacts = util.PrintContactsList("", ContactsListBox, contacts, user.Id, true);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir bağlantı seçiniz.");
                return;
            }
            contacts[selectedIndex].SoftDeleteContact();
            contacts = util.PrintContactsList("", ContactsListBox, contacts, user.Id, true);
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
            Form DeletedContacts = new DeletedContacts(user, false);
            DeletedContacts.Show();
        }

        private void ChangePasswordStripTool_Click(object sender, EventArgs e)
        {
            Form ChangePwd = new ChangePassword(user);
            ChangePwd.ShowDialog();
        }

        private void UserPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void EndTimePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        private void UpcomingMeetingsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int meetingsSelectedIndex = UpcomingMeetingsList.SelectedIndex;
            if (meetingsSelectedIndex == -1)
            {
                return;
            }

            try
            {
                selectedMeeting = meetings[meetingsSelectedIndex];
                fullNamePrompt.Text = meetings[meetingsSelectedIndex].Contact._name.ToString() + " " + meetings[meetingsSelectedIndex].Contact._surname.ToString();
                StartTimePicker.Value = meetings[meetingsSelectedIndex].MeetingStartDate;
                EndTimePicker.Value = meetings[meetingsSelectedIndex].MeetingEndDate;
                NotesPrompt.Text = meetings[meetingsSelectedIndex].MeetingNotes;
            }
            catch (Exception)
            {

                return;
            }
        }

        private void AddMeetingToolStrip_Click(object sender, EventArgs e)
        {
            Form AddMeeting = new AddMeeting(user);
            AddMeeting.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            meetings = util.PrintMeetingsList("", UpcomingMeetingsList, meetings, true, user, false,
                DateTime.Now.AddYears(-100), DateTime.MaxValue);
        }

        private void UpdateMeetingButton_Click(object sender, EventArgs e)
        {
            selectedMeeting.Contact = contacts[selectedIndex];
            selectedMeeting.MeetingNotes = NotesPrompt.Text;
            selectedMeeting.UpdateMeeting();
        }

        private void DeleteMeetingButton_Click(object sender, EventArgs e)
        {
            selectedMeeting.RemoveMeeting();
        }

        private void DeletedMeetingsToolStrip_Click(object sender, EventArgs e)
        {
            Form DeletedMeetings = new DeletedMeetings(user);
            DeletedMeetings.ShowDialog();
        }

        private void MeetingsSearchBar_TextChanged(object sender, EventArgs e)
        {
            string input = MeetingsSearchBar.Text;
            input = util.ConvertInputToAscii(input);

            meetings = util.PrintMeetingsList(input, UpcomingMeetingsList, meetings, true, user, false,
                DateTime.Now.AddYears(-100), DateTime.MaxValue);
        }

        private void PreviousMeetingsToolStrip_Click(object sender, EventArgs e)
        {
            Form PreviousMeetings = new PreviousMeetings(user);
            PreviousMeetings.ShowDialog();
        }

        private void NewMeetingToolstrip_Click(object sender, EventArgs e)
        {
            Form AddConference = new AddConference(user);
            AddConference.ShowDialog();
        }

        private void ConferenceNotificationsToolstripMenuItem_Click(object sender, EventArgs e)
        {
            Form ConferenceNotifications = new ConferenceNotifications(user);
            ConferenceNotifications.ShowDialog();
        }

        private void ConferencesDashBoardToolstrip_Click(object sender, EventArgs e)
        {
            Form Conferences = new Conferences();
            Conferences.ShowDialog();
        }
    }
}
