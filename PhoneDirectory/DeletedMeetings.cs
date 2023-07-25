using PhoneDirectory.Scripts;

namespace PhoneDirectory
{
    public partial class DeletedMeetings : Form
    {
        private User user = new User();
        private UsefulUtilities util = new UsefulUtilities();

        private List<Meeting> meetings = new List<Meeting>();
        private Meeting selectedMeeting = new Meeting();

        private bool isPreviousMeeting = true;

        private string userSearchWord = "";

        public DeletedMeetings(User user)
        {
            InitializeComponent();
            this.user = user;

            


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

            meetings = util.PrintMeetingsList("", UpcomingMeetingsList, meetings, false, user,
                isPreviousMeeting, IntervalCalendar.SelectionStart, IntervalCalendar.SelectionEnd);
        }

        private void DeleteMeetingButton_Click(object sender, EventArgs e)
        {
            selectedMeeting.RemoveMeeting();
            meetings = util.PrintMeetingsList("", UpcomingMeetingsList, meetings, false, user,
                isPreviousMeeting, IntervalCalendar.SelectionStart, IntervalCalendar.SelectionEnd);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MeetingsSearchBar_TextChanged(object sender, EventArgs e)
        {
            userSearchWord = MeetingsSearchBar.Text;
            userSearchWord = util.ConvertInputToAscii(userSearchWord);

            meetings = util.PrintMeetingsList(userSearchWord, UpcomingMeetingsList, meetings, false, user,
                               isPreviousMeeting, IntervalCalendar.SelectionStart, IntervalCalendar.SelectionEnd);

        }

        private void DeletedMeetings_Load(object sender, EventArgs e)
        {
            IntervalCalendar.MaxSelectionCount = 61;
            IntervalCalendar.SelectionRange = new SelectionRange(DateTime.Now.AddDays(-60), DateTime.Now);

            meetings = util.PrintMeetingsList("", UpcomingMeetingsList, meetings, false, user,
                isPreviousMeeting, IntervalCalendar.SelectionStart, IntervalCalendar.SelectionEnd);
        }

        private void FlipStatusButton_Click(object sender, EventArgs e)
        {
            isPreviousMeeting = !isPreviousMeeting;

            meetings = util.PrintMeetingsList(userSearchWord, UpcomingMeetingsList, meetings, false, user,
                isPreviousMeeting, IntervalCalendar.SelectionStart, IntervalCalendar.SelectionEnd);

            if (isPreviousMeeting)
            {
                FlipStatusButton.Text = "Geçmiş Toplantıları Göster";
            }
            else
            {
                FlipStatusButton.Text = "Gelecek Toplantıları Göster";
            }
        }

        private void UpdateIntervalButton_Click(object sender, EventArgs e)
        {
            meetings = util.PrintMeetingsList(userSearchWord, UpcomingMeetingsList, meetings, false, user,
                isPreviousMeeting, IntervalCalendar.SelectionStart, IntervalCalendar.SelectionEnd);
        }

        private void MeetingsSearchBar_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
