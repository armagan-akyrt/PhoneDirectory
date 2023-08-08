namespace PhoneDirectory
{
    partial class ConferenceNotifications
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConferenceNotifications));
            groupBox1 = new GroupBox();
            OverseerApproveRequest = new Button();
            OverseerRejectRequest = new Button();
            OverseerRequestList = new ListBox();
            groupBox2 = new GroupBox();
            AcceptParticipationButton = new Button();
            ParticipationList = new ListBox();
            RejectParticipationButton = new Button();
            groupBox3 = new GroupBox();
            NotificationsList = new ListBox();
            ClearNotificationsButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OverseerApproveRequest);
            groupBox1.Controls.Add(OverseerRejectRequest);
            groupBox1.Controls.Add(OverseerRequestList);
            groupBox1.Location = new Point(12, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 529);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bekleyen Toplantı İstekleri";
            // 
            // OverseerApproveRequest
            // 
            OverseerApproveRequest.Location = new Point(138, 492);
            OverseerApproveRequest.Name = "OverseerApproveRequest";
            OverseerApproveRequest.Size = new Size(75, 23);
            OverseerApproveRequest.TabIndex = 2;
            OverseerApproveRequest.Text = "Onayla";
            OverseerApproveRequest.UseVisualStyleBackColor = true;
            OverseerApproveRequest.Click += OverseerApproveRequest_Click;
            // 
            // OverseerRejectRequest
            // 
            OverseerRejectRequest.Location = new Point(219, 492);
            OverseerRejectRequest.Name = "OverseerRejectRequest";
            OverseerRejectRequest.Size = new Size(75, 23);
            OverseerRejectRequest.TabIndex = 1;
            OverseerRejectRequest.Text = "Reddet";
            OverseerRejectRequest.UseVisualStyleBackColor = true;
            OverseerRejectRequest.Click += OverseerRejectRequest_Click;
            // 
            // OverseerRequestList
            // 
            OverseerRequestList.FormattingEnabled = true;
            OverseerRequestList.ItemHeight = 15;
            OverseerRequestList.Location = new Point(6, 32);
            OverseerRequestList.Name = "OverseerRequestList";
            OverseerRequestList.Size = new Size(288, 454);
            OverseerRequestList.TabIndex = 0;
            OverseerRequestList.SelectedIndexChanged += OverseerRequestList_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(AcceptParticipationButton);
            groupBox2.Controls.Add(ParticipationList);
            groupBox2.Controls.Add(RejectParticipationButton);
            groupBox2.Location = new Point(349, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 529);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bekleyen Katılım İstekleri";
            // 
            // AcceptParticipationButton
            // 
            AcceptParticipationButton.Location = new Point(138, 492);
            AcceptParticipationButton.Name = "AcceptParticipationButton";
            AcceptParticipationButton.Size = new Size(75, 23);
            AcceptParticipationButton.TabIndex = 5;
            AcceptParticipationButton.Text = "Kabul Et";
            AcceptParticipationButton.UseVisualStyleBackColor = true;
            AcceptParticipationButton.Click += AcceptParticipationButton_Click;
            // 
            // ParticipationList
            // 
            ParticipationList.FormattingEnabled = true;
            ParticipationList.ItemHeight = 15;
            ParticipationList.Location = new Point(6, 32);
            ParticipationList.Name = "ParticipationList";
            ParticipationList.Size = new Size(288, 454);
            ParticipationList.TabIndex = 3;
            ParticipationList.SelectedIndexChanged += ParticipationList_SelectedIndexChanged;
            // 
            // RejectParticipationButton
            // 
            RejectParticipationButton.Location = new Point(219, 492);
            RejectParticipationButton.Name = "RejectParticipationButton";
            RejectParticipationButton.Size = new Size(75, 23);
            RejectParticipationButton.TabIndex = 4;
            RejectParticipationButton.Text = "Reddet";
            RejectParticipationButton.UseVisualStyleBackColor = true;
            RejectParticipationButton.Click += RejectParticipationButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(NotificationsList);
            groupBox3.Controls.Add(ClearNotificationsButton);
            groupBox3.Location = new Point(677, 38);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 529);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Bildirimler";
            // 
            // NotificationsList
            // 
            NotificationsList.FormattingEnabled = true;
            NotificationsList.ItemHeight = 15;
            NotificationsList.Location = new Point(6, 32);
            NotificationsList.Name = "NotificationsList";
            NotificationsList.Size = new Size(288, 454);
            NotificationsList.TabIndex = 6;
            // 
            // ClearNotificationsButton
            // 
            ClearNotificationsButton.Location = new Point(219, 492);
            ClearNotificationsButton.Name = "ClearNotificationsButton";
            ClearNotificationsButton.Size = new Size(75, 23);
            ClearNotificationsButton.TabIndex = 7;
            ClearNotificationsButton.Text = "Temizle";
            ClearNotificationsButton.UseVisualStyleBackColor = true;
            ClearNotificationsButton.Click += ClearNotificationsButton_Click;
            // 
            // ConferenceNotifications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 579);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConferenceNotifications";
            Text = "Konferans Bildirimleri";
            Load += ConferenceNotifications_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button OverseerApproveRequest;
        private Button OverseerRejectRequest;
        private ListBox OverseerRequestList;
        private GroupBox groupBox2;
        private Button AcceptParticipationButton;
        private ListBox ParticipationList;
        private Button RejectParticipationButton;
        private GroupBox groupBox3;
        private ListBox NotificationsList;
        private Button ClearNotificationsButton;
    }
}