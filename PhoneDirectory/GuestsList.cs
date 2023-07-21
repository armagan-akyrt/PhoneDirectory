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
    public partial class GuestsList : Form
    {
        private bool isInside;
        private List<Guest> guests = new List<Guest>();

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

            Guest guest = guests[selectedIndex];
            FirstNamePrompt.Text = guest.Name;
            LastNamePrompt.Text = guest.Surname;

            VisitedGuestBox.Text = guest.Visiting.Name + " " + guest.Visiting.Surname;
            AcquireDateTimePicker.Value = guest.CardAcquisitionDate;
            SubmitDateTimePicker.Value = (isInside) ? DateTime.UtcNow : guest.CardSubmitDate;
        }
    }
}
