using PhoneDirectory.Scripts;

namespace PhoneDirectory
{
    public partial class GuestsList : Form
    {
        private bool isInside;
        private List<Guest> guests = new List<Guest>();
        private Guest selectedGuest = new Guest();

        private UsefulUtilities util = new UsefulUtilities();

        private DateTime startDate;
        private DateTime endDate;

        private string companyName = "";
        private string searchWord = "";

        public GuestsList(bool isInside)
        {
            this.isInside = isInside;
            InitializeComponent();
        }

        private void GuestsList_Load(object sender, EventArgs e)
        {
            IntervalCalendar.MaxSelectionCount = 61;
            IntervalCalendar.SelectionStart = DateTime.Now.AddMonths(-1);
            IntervalCalendar.SelectionEnd = DateTime.Now;

            startDate = IntervalCalendar.SelectionStart;
            endDate = IntervalCalendar.SelectionEnd;


            guests = util.PrintGuestList("", GuestsListBox, guests, isInside, startDate, endDate, companyName);
            if (isInside)
            {
                label4.Hide();
                SubmitDateTimePicker.Hide();
            }
            else
            {
                GetCardButton.Hide();
            }

        }

        private void GuestsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = GuestsListBox.SelectedIndex;
            if (selectedIndex < 0)
            {
                return;
            }

            selectedGuest = guests[selectedIndex];
            FirstNamePrompt.Text = selectedGuest.Name;
            LastNamePrompt.Text = selectedGuest.Surname;

            VisitedGuestBox.Text = selectedGuest.Visiting.Name + " " + selectedGuest.Visiting.Surname;
            AcquireDateTimePicker.Value = selectedGuest.CardAcquisitionDate;
            SubmitDateTimePicker.Value = (isInside) ? DateTime.UtcNow : selectedGuest.CardSubmitDate;
            CompanyNameBox.Text = selectedGuest.CompanyName;
        }

        private void GetCardButton_Click(object sender, EventArgs e)
        {
            if (selectedGuest.ObtainCard())
            {
                MessageBox.Show("Kart başarıyla teslim alındı.");
                return;
            }

            MessageBox.Show("Kart teslim alınamadı.");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            selectedGuest.DeleteGuest();
        }

        private void GuestSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (GuestSearchBar.Text == "Kullanıcı adıyla ara")
                return;

            searchWord = GuestSearchBar.Text;
            searchWord = util.ConvertInputToAscii(searchWord);

            guests = util.PrintGuestList(searchWord, GuestsListBox, guests, isInside, startDate, endDate, companyName);
        }

        private void UpdateHistoryInterval_Click(object sender, EventArgs e)
        {
            startDate = IntervalCalendar.SelectionStart;
            endDate = IntervalCalendar.SelectionEnd;

            guests = util.PrintGuestList(searchWord, GuestsListBox, guests, isInside, startDate, endDate, companyName);
        }

        private void GuestSearchBar_Enter(object sender, EventArgs e)
        {
            if (GuestSearchBar.Text == "Kullanıcı adıyla ara")
                GuestSearchBar.Text = "";
        }

        private void GuestSearchBar_Leave(object sender, EventArgs e)
        {
            if (GuestSearchBar.Text == "")
                GuestSearchBar.Text = "Kullanıcı adıyla ara";

        }

        private void CompanyNameSearch_Enter(object sender, EventArgs e)
        {
            if (CompanyNameSearch.Text == "Firma adıyla ara")
                CompanyNameSearch.Text = "";
        }

        private void CompanyNameSearch_Leave(object sender, EventArgs e)
        {
            if (CompanyNameSearch.Text == "")
                CompanyNameSearch.Text = "Firma adıyla ara";
        }

        private void CompanyNameSearch_TextChanged(object sender, EventArgs e)
        {
            if (CompanyNameSearch.Text == "Firma adıyla ara")
                return;

            companyName = CompanyNameSearch.Text;
            companyName = companyName.ToLower();

            guests = util.PrintGuestList(searchWord, GuestsListBox, guests, isInside, startDate, endDate, companyName);



        }
    }
}
