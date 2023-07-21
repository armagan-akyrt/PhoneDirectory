using PhoneDirectory.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneDirectory
{
    public partial class AddMeeting : Form
    {
        private List<Contact> contacts = new List<Contact>();
        private User user = new User();
        private Meeting meetingToCreate = new Meeting();

        private UsefulUtilities util = new UsefulUtilities();

        public AddMeeting(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddMeeting_Load(object sender, EventArgs e)
        {
            meetingToCreate.User = user;
            contacts = util.PrintContactsList("", ContactsListBox, contacts, user.Username, true);
        }

        private void ContactSearchBar_TextChanged(object sender, EventArgs e)
        {
            string searchInput = util.ConvertInputToAscii(ContactSearchBar.Text);

            contacts = util.PrintContactsList(searchInput, ContactsListBox, contacts, user.Username, true);
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex < 0)
            {
                return;
            }

            try
            {
                meetingToCreate.Contact = contacts[ContactsListBox.SelectedIndex];
            }
            catch (Exception)
            {

                return;
            }
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            meetingToCreate.MeetingStartDate = StartDatePicker.Value;
        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            meetingToCreate.MeetingEndDate = EndDatePicker.Value;
        }

        private void AddMeetingButton_Click(object sender, EventArgs e)
        {
            meetingToCreate.MeetingNotes = NotesBox.Text;
            meetingToCreate.CreateMeeting();
        }
    }
}
