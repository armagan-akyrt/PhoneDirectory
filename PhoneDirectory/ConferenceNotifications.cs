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
    public partial class ConferenceNotifications : Form
    {
        private User currentUser = new User();

        private List<Conference> overseerRequests = new List<Conference>();
        private List<Conference> participantRequests = new List<Conference>();

        private int selectedOverseerRequestIndex = -1;

        public ConferenceNotifications(User user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        private void OverseerRequestList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConferenceNotifications_Load(object sender, EventArgs e)
        {
            overseerRequests = ListConferences(OverseerRequestList, overseerRequests, true);
            participantRequests = ListConferences(ParticipationList, participantRequests, false);
        }

        private List<Conference> ListConferences(ListBox lb, List<Conference> conferences, bool isOverseer)
        {
            conferences = (isOverseer) ? new Conference().ListPendingApprovals(currentUser.Id) : new Conference().ListParticipantRequsts(currentUser.Id);
            
            lb.Items.Clear();

            foreach (Conference conference in conferences)
            {
                string text = "Oda #ROOM_ID Konu: CONFERENCE_TOPIC - START_DATE - END_DATE".Replace("CONFERENCE_TOPIC", conference.Topic).Replace("ROOM_ID", conference.ConferenceRoom.RoomId.ToString())
                    .Replace("START_DATE", conference.StartDate.ToShortTimeString()).Replace("END_DATE", conference.EndDate.ToShortTimeString());
            
                lb.Items.Add(text);
            
            }

            return conferences;
        }
    }
}
