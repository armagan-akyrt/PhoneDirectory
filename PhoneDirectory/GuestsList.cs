using PhoneDirectory.Scripts;

namespace PhoneDirectory
{
    public partial class GuestsList : Form
    {
        private bool isInside;
        private List<Guest> guests = new List<Guest>();
        private Guest selectedGuest = new Guest();

        private UsefulUtilities util = new UsefulUtilities();

        public GuestsList(bool isInside)
        {
            this.isInside = isInside;
            InitializeComponent();
        }

        private void GuestsList_Load(object sender, EventArgs e)
        {
            guests = util.PrintGuestList("", GuestsListBox, guests, isInside);
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
    }
}
