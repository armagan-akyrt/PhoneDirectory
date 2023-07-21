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
    public partial class DeletedMeetings : Form
    {
        private User user = new User();
        private UsefulUtilities util = new UsefulUtilities();

        private List<Meeting> meetings = new List<Meeting>();
        private Meeting selectedMeeting = new Meeting();

        public DeletedMeetings(User user)
        {
            InitializeComponent();
            this.user = user;

            meetings = util.PrintMeetingsList("", UpcomingMeetingsList, meetings, false, user);


        }

        private void UpcomingMeetingsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = UpcomingMeetingsList.SelectedIndex;
            if (selectedIndex < 0)
            {
                return;
            }
            try
            {
                selectedMeeting = meetings[selectedIndex];

                fullNamePrompt.Text = selectedMeeting.Contact._name + " " + selectedMeeting.Contact._surname;
                StartTimePicker.Value = selectedMeeting.MeetingStartDate;
                EndTimePicker.Value = selectedMeeting.MeetingEndDate;
                NotesPrompt.Text = selectedMeeting.MeetingNotes;
            }
            catch (Exception)
            {

                return;
            }

        }

        private void UpdateMeetingButton_Click(object sender, EventArgs e)
        {
            selectedMeeting.UpdateMeeting();
            selectedMeeting.BringBackMeeting();

            meetings = util.PrintMeetingsList("", UpcomingMeetingsList, meetings, false, user);
        }

        private void DeleteMeetingButton_Click(object sender, EventArgs e)
        {
            selectedMeeting.RemoveMeeting();
            meetings = util.PrintMeetingsList("", UpcomingMeetingsList, meetings, false, user);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MeetingsSearchBar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
