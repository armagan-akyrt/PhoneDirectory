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
        private Conference overseerRequest = new Conference();

        private List<Conference> participantRequests = new List<Conference>();
        private Conference participantRequest = new Conference();

        private List<Notification> notifications = new List<Notification>();
        private Notification notification = new Notification();


        public ConferenceNotifications(User user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        private void OverseerRequestList_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = OverseerRequestList.SelectedIndex;
            if (selectedIndex < 0)
            {
                return;
            }

            overseerRequest = overseerRequests[selectedIndex];

        }

        private void ConferenceNotifications_Load(object sender, EventArgs e)
        {
            overseerRequests = ListConferences(OverseerRequestList, overseerRequests, true);
            participantRequests = ListConferences(ParticipationList, participantRequests, false);
            notifications = ListNotifications(NotificationsList, notifications);
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

        private List<Notification> ListNotifications(ListBox lb, List<Notification> notifications)
        {
            notifications = new Conference().ListNotifications(currentUser.Id);

            lb.Items.Clear();
            foreach (var notification in notifications)
            {
                string statusMessage = (notification.Status.Equals("rejected")) ? "iptal edildi" : "onaylandı";
                string text = "'CON_TOPIC' konulu toplantınız CON_STATUS".Replace("CON_TOPIC", notification.Topic).Replace("CON_STATUS", statusMessage);

                lb.Items.Add(text);
            }

            return notifications;
        }

        private void OverseerApproveRequest_Click(object sender, EventArgs e)
        {
            overseerRequest.OverseerRequestResponse(currentUser.Id, true);
            overseerRequests = ListConferences(OverseerRequestList, overseerRequests, true);
        }

        private void OverseerRejectRequest_Click(object sender, EventArgs e)
        {
            overseerRequest.OverseerRequestResponse(currentUser.Id, false);
            overseerRequests = ListConferences(OverseerRequestList, overseerRequests, true);
        }

        private void ParticipationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ParticipationList.SelectedIndex;
            if (selectedIndex < 0)
            {
                return;
            }

            participantRequest = participantRequests[selectedIndex];
        }

        private void AcceptParticipationButton_Click(object sender, EventArgs e)
        {
            participantRequest.ParticipantResponse(currentUser.Id, true);
            participantRequests = ListConferences(ParticipationList, participantRequests, false);
        }

        private void RejectParticipationButton_Click(object sender, EventArgs e)
        {
            participantRequest.ParticipantResponse(currentUser.Id, false);
            participantRequests = ListConferences(ParticipationList, participantRequests, false);
        }

        private void ClearNotificationsButton_Click(object sender, EventArgs e)
        {
            new Conference().ClearNotifications(currentUser.Id);
            notifications = ListNotifications(NotificationsList, notifications);
        }
    }
}
