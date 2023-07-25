using PhoneDirectory.Scripts;

namespace PhoneDirectory
{
    public partial class PreviousMeetings : Form
    {

        private List<Meeting> meetings = new List<Meeting>();
        private Meeting selectedMeeting = new Meeting();

        private User user = new User();

        UsefulUtilities util = new UsefulUtilities();

        private string searchWord = "";

        public PreviousMeetings(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void PreviousMeetings_Load(object sender, EventArgs e)
        {
            IntervalCalendar.MaxSelectionCount = 61;
            IntervalCalendar.SelectionRange = new SelectionRange(DateTime.Now.AddDays(-60), DateTime.Now);

            meetings = util.PrintMeetingsList("", PreviousMeetingsList, meetings, true, user, true,
                IntervalCalendar.SelectionStart, IntervalCalendar.SelectionEnd);
        }

        private void PreviousMeetingsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = PreviousMeetingsList.SelectedIndex;
            if (selectedIndex < 0)
            {
                return;
            }

            try
            {
                selectedMeeting = meetings[selectedIndex];
                FullNamePrompt.Text = selectedMeeting.Contact._name + " " + selectedMeeting.Contact._surname;
                StartDateTimePicker.Value = selectedMeeting.MeetingStartDate;
                EndDateTimePicker.Value = selectedMeeting.MeetingEndDate;
                NotesBox.Text = selectedMeeting.MeetingNotes;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            selectedMeeting.RemoveMeeting();
        }

        private void UpdateIntervalButton_Click(object sender, EventArgs e)
        {
            meetings = util.PrintMeetingsList(searchWord, PreviousMeetingsList, meetings, true, user, true,
                IntervalCalendar.SelectionStart, IntervalCalendar.SelectionEnd);
        }

        private void PreviousMeetingsSearchBar_TextChanged(object sender, EventArgs e)
        {
            searchWord = PreviousMeetingsSearchBar.Text;
            searchWord = util.ConvertInputToAscii(searchWord);

            meetings = util.PrintMeetingsList(searchWord, PreviousMeetingsList, meetings, true, user, true,
                               IntervalCalendar.SelectionStart, IntervalCalendar.SelectionEnd);
        }
    }
}
