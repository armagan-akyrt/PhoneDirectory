using System;
using System.Collections.Generic;
using System.ComponentModel;
using PhoneDirectory.Scripts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace PhoneDirectory
{


    public partial class Conferences : Form
    {
        private List<ConferenceRoom> conferences;

        public Conferences()
        {
            conferences = new ConferenceRoom().GetConferenceRooms();

            InitializeComponent();
            RenderRooms();

        }

        private void RenderRooms()
        {
            int x = 10;
            int y = 10;
            int width = 200;
            int height = 200;
            int margin = 10;

            foreach (var conference in conferences)
            {
                Panel roomPanel = new Panel
                {
                    Size = new Size(width, height),
                    Location = new Point(x, y),
                    BackColor = conference.IsEmpty ? Color.Green : Color.Red,
                    BorderStyle = BorderStyle.Fixed3D
                };
                string participants = (conference.IsEmpty) ? string.Empty: conference.GetParticipants();
                string roomText = (conference.IsEmpty) ? $"Oda: #{conference.RoomId}" :
                     $"Oda #{conference.RoomId}\n " +
                    $"Başlangıç Tarihi: {conference.StartDate}\n" +
                    $"Bitiş Tarihi: {conference.EndDate}\n" +
                    $"Katılımcılar: {participants}";
                Label roomLabel = new Label
                {

                    Text = roomText,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };

                roomPanel.Controls.Add(roomLabel);
                this.Controls.Add(roomPanel);

                x += width + margin;
                if (x + width > this.Width)
                {
                    x = 10;
                    y += height + margin;
                }
            }
        }

        private class Room
        {
            public int Id { get; set; }
            public bool IsOccupied { get; set; }
        }

        private void AddRoomToolStripMenu_Click(object sender, EventArgs e)
        {
            Form AddNewRoom = new AddNewRoom();
            AddNewRoom.ShowDialog();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            conferences = new ConferenceRoom().GetConferenceRooms();
            RenderRooms();
        }
    }


}
