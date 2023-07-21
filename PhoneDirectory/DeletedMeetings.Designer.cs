namespace PhoneDirectory
{
    partial class DeletedMeetings
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
            groupBox2 = new GroupBox();
            GuestMeetingsList = new ListBox();
            MeetingsSearchBar = new TextBox();
            UpcomingMeetingsList = new ListBox();
            EndTimePicker = new DateTimePicker();
            StartTimePicker = new DateTimePicker();
            DeleteMeetingButton = new Button();
            UpdateMeetingButton = new Button();
            NotesPrompt = new RichTextBox();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            fullNamePrompt = new TextBox();
            label10 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(GuestMeetingsList);
            groupBox2.Controls.Add(MeetingsSearchBar);
            groupBox2.Controls.Add(UpcomingMeetingsList);
            groupBox2.Location = new Point(12, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(295, 420);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gelecek Toplantılar:";
            // 
            // GuestMeetingsList
            // 
            GuestMeetingsList.FormattingEnabled = true;
            GuestMeetingsList.ItemHeight = 15;
            GuestMeetingsList.Location = new Point(15, 276);
            GuestMeetingsList.Name = "GuestMeetingsList";
            GuestMeetingsList.Size = new Size(262, 124);
            GuestMeetingsList.TabIndex = 2;
            // 
            // MeetingsSearchBar
            // 
            MeetingsSearchBar.Location = new Point(15, 22);
            MeetingsSearchBar.Name = "MeetingsSearchBar";
            MeetingsSearchBar.Size = new Size(262, 23);
            MeetingsSearchBar.TabIndex = 1;
            // 
            // UpcomingMeetingsList
            // 
            UpcomingMeetingsList.FormattingEnabled = true;
            UpcomingMeetingsList.ItemHeight = 15;
            UpcomingMeetingsList.Location = new Point(15, 52);
            UpcomingMeetingsList.Name = "UpcomingMeetingsList";
            UpcomingMeetingsList.Size = new Size(262, 214);
            UpcomingMeetingsList.TabIndex = 0;
            UpcomingMeetingsList.SelectedIndexChanged += UpcomingMeetingsList_SelectedIndexChanged;
            // 
            // EndTimePicker
            // 
            EndTimePicker.CustomFormat = "dd/MM/yy - HH.mm";
            EndTimePicker.Format = DateTimePickerFormat.Custom;
            EndTimePicker.Location = new Point(313, 164);
            EndTimePicker.Name = "EndTimePicker";
            EndTimePicker.Size = new Size(239, 23);
            EndTimePicker.TabIndex = 43;
            // 
            // StartTimePicker
            // 
            StartTimePicker.CustomFormat = "dd/MM/yy - HH.mm";
            StartTimePicker.Format = DateTimePickerFormat.Custom;
            StartTimePicker.Location = new Point(313, 108);
            StartTimePicker.Name = "StartTimePicker";
            StartTimePicker.Size = new Size(239, 23);
            StartTimePicker.TabIndex = 42;
            // 
            // DeleteMeetingButton
            // 
            DeleteMeetingButton.Location = new Point(313, 407);
            DeleteMeetingButton.Name = "DeleteMeetingButton";
            DeleteMeetingButton.Size = new Size(75, 23);
            DeleteMeetingButton.TabIndex = 41;
            DeleteMeetingButton.Text = "Sil";
            DeleteMeetingButton.UseVisualStyleBackColor = true;
            DeleteMeetingButton.Click += DeleteMeetingButton_Click;
            // 
            // UpdateMeetingButton
            // 
            UpdateMeetingButton.Location = new Point(415, 407);
            UpdateMeetingButton.Name = "UpdateMeetingButton";
            UpdateMeetingButton.Size = new Size(137, 23);
            UpdateMeetingButton.TabIndex = 40;
            UpdateMeetingButton.Text = "Güncelle ve Geri Getir";
            UpdateMeetingButton.UseVisualStyleBackColor = true;
            UpdateMeetingButton.Click += UpdateMeetingButton_Click;
            // 
            // NotesPrompt
            // 
            NotesPrompt.Location = new Point(313, 217);
            NotesPrompt.Name = "NotesPrompt";
            NotesPrompt.Size = new Size(239, 177);
            NotesPrompt.TabIndex = 39;
            NotesPrompt.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 199);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 38;
            label1.Text = "Not";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(313, 146);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 37;
            label7.Text = "Bitiş";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(313, 90);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 36;
            label8.Text = "Başlangıç";
            // 
            // fullNamePrompt
            // 
            fullNamePrompt.Location = new Point(313, 54);
            fullNamePrompt.Name = "fullNamePrompt";
            fullNamePrompt.Size = new Size(239, 23);
            fullNamePrompt.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(313, 36);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 34;
            label10.Text = "Ad Soyad";
            // 
            // DeletedMeetings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EndTimePicker);
            Controls.Add(StartTimePicker);
            Controls.Add(DeleteMeetingButton);
            Controls.Add(UpdateMeetingButton);
            Controls.Add(NotesPrompt);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(fullNamePrompt);
            Controls.Add(label10);
            Controls.Add(groupBox2);
            Name = "DeletedMeetings";
            Text = "DeletedMeetings";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private ListBox GuestMeetingsList;
        private TextBox MeetingsSearchBar;
        private ListBox UpcomingMeetingsList;
        private DateTimePicker EndTimePicker;
        private DateTimePicker StartTimePicker;
        private Button DeleteMeetingButton;
        private Button UpdateMeetingButton;
        private RichTextBox NotesPrompt;
        private Label label1;
        private Label label7;
        private Label label8;
        private TextBox fullNamePrompt;
        private Label label10;
    }
}