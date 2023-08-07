namespace PhoneDirectory
{
    partial class AddConference
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
            groupBox1 = new GroupBox();
            UserSearchBar = new TextBox();
            UsersListBox = new ListBox();
            groupBox4 = new GroupBox();
            label11 = new Label();
            UserRoleBox = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            AddParticipant = new Button();
            UserAddressPrompt = new RichTextBox();
            UserEmailPrompt = new TextBox();
            UserGsmPrompt = new TextBox();
            UserLastNamePrompt = new TextBox();
            UserFirstNamePropmt = new TextBox();
            groupBox2 = new GroupBox();
            CreateRequestButton = new Button();
            label12 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ConferenceRoomSelection = new ComboBox();
            EndDatePicker = new DateTimePicker();
            StartDatePicker = new DateTimePicker();
            NotesPrompt = new TextBox();
            DescriptionPrompt = new TextBox();
            TopicPrompt = new TextBox();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(UserSearchBar);
            groupBox1.Controls.Add(UsersListBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 393);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Listesi:";
            // 
            // UserSearchBar
            // 
            UserSearchBar.Location = new Point(6, 23);
            UserSearchBar.Name = "UserSearchBar";
            UserSearchBar.Size = new Size(250, 23);
            UserSearchBar.TabIndex = 1;
            // 
            // UsersListBox
            // 
            UsersListBox.FormattingEnabled = true;
            UsersListBox.ItemHeight = 15;
            UsersListBox.Location = new Point(6, 52);
            UsersListBox.Name = "UsersListBox";
            UsersListBox.Size = new Size(250, 334);
            UsersListBox.TabIndex = 0;
            UsersListBox.SelectedIndexChanged += UsersListBox_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(UserRoleBox);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(AddParticipant);
            groupBox4.Controls.Add(UserAddressPrompt);
            groupBox4.Controls.Add(UserEmailPrompt);
            groupBox4.Controls.Add(UserGsmPrompt);
            groupBox4.Controls.Add(UserLastNamePrompt);
            groupBox4.Controls.Add(UserFirstNamePropmt);
            groupBox4.Location = new Point(280, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(338, 393);
            groupBox4.TabIndex = 34;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kullanıcı Bilgileri";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 165);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 22;
            label11.Text = "Rol:";
            // 
            // UserRoleBox
            // 
            UserRoleBox.FormattingEnabled = true;
            UserRoleBox.Items.AddRange(new object[] { "ADMIN", "USER" });
            UserRoleBox.Location = new Point(102, 162);
            UserRoleBox.Name = "UserRoleBox";
            UserRoleBox.Size = new Size(220, 23);
            UserRoleBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 239);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 21;
            label6.Text = "Adres:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 202);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 20;
            label7.Text = "E-posta:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 128);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 19;
            label8.Text = "Tel. No:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 91);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 18;
            label9.Text = "Soyad:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 59);
            label10.Name = "label10";
            label10.Size = new Size(25, 15);
            label10.TabIndex = 17;
            label10.Text = "Ad:";
            // 
            // AddParticipant
            // 
            AddParticipant.Location = new Point(247, 354);
            AddParticipant.Name = "AddParticipant";
            AddParticipant.Size = new Size(75, 23);
            AddParticipant.TabIndex = 16;
            AddParticipant.Text = "Davet Et";
            AddParticipant.UseVisualStyleBackColor = true;
            // 
            // UserAddressPrompt
            // 
            UserAddressPrompt.Location = new Point(102, 239);
            UserAddressPrompt.Name = "UserAddressPrompt";
            UserAddressPrompt.Size = new Size(220, 109);
            UserAddressPrompt.TabIndex = 15;
            UserAddressPrompt.Text = "";
            // 
            // UserEmailPrompt
            // 
            UserEmailPrompt.Location = new Point(102, 199);
            UserEmailPrompt.Name = "UserEmailPrompt";
            UserEmailPrompt.Size = new Size(220, 23);
            UserEmailPrompt.TabIndex = 14;
            // 
            // UserGsmPrompt
            // 
            UserGsmPrompt.Location = new Point(102, 125);
            UserGsmPrompt.Name = "UserGsmPrompt";
            UserGsmPrompt.Size = new Size(220, 23);
            UserGsmPrompt.TabIndex = 13;
            // 
            // UserLastNamePrompt
            // 
            UserLastNamePrompt.Location = new Point(102, 88);
            UserLastNamePrompt.Name = "UserLastNamePrompt";
            UserLastNamePrompt.Size = new Size(220, 23);
            UserLastNamePrompt.TabIndex = 12;
            // 
            // UserFirstNamePropmt
            // 
            UserFirstNamePropmt.Location = new Point(102, 51);
            UserFirstNamePropmt.Name = "UserFirstNamePropmt";
            UserFirstNamePropmt.Size = new Size(220, 23);
            UserFirstNamePropmt.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CreateRequestButton);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(ConferenceRoomSelection);
            groupBox2.Controls.Add(EndDatePicker);
            groupBox2.Controls.Add(StartDatePicker);
            groupBox2.Controls.Add(NotesPrompt);
            groupBox2.Controls.Add(DescriptionPrompt);
            groupBox2.Controls.Add(TopicPrompt);
            groupBox2.Location = new Point(624, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 393);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Konferans Bilgileri";
            // 
            // CreateRequestButton
            // 
            CreateRequestButton.Location = new Point(190, 354);
            CreateRequestButton.Name = "CreateRequestButton";
            CreateRequestButton.Size = new Size(136, 23);
            CreateRequestButton.TabIndex = 13;
            CreateRequestButton.Text = "İstek Oluştur";
            CreateRequestButton.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 305);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 12;
            label12.Text = "Bitiş Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 263);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 11;
            label5.Text = "Başlangıç Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 215);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 10;
            label4.Text = "Konferans Odası:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 143);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 9;
            label3.Text = "Notlar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 106);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 8;
            label2.Text = "Açıklama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 59);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 7;
            label1.Text = "Konu:";
            // 
            // ConferenceRoomSelection
            // 
            ConferenceRoomSelection.FormattingEnabled = true;
            ConferenceRoomSelection.Location = new Point(126, 215);
            ConferenceRoomSelection.Name = "ConferenceRoomSelection";
            ConferenceRoomSelection.Size = new Size(200, 23);
            ConferenceRoomSelection.TabIndex = 6;
            // 
            // EndDatePicker
            // 
            EndDatePicker.CustomFormat = "dd/MM/yy - hh.mm";
            EndDatePicker.Format = DateTimePickerFormat.Custom;
            EndDatePicker.Location = new Point(126, 299);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(200, 23);
            EndDatePicker.TabIndex = 5;
            // 
            // StartDatePicker
            // 
            StartDatePicker.CustomFormat = "dd/MM/yy - hh.mm";
            StartDatePicker.Format = DateTimePickerFormat.Custom;
            StartDatePicker.Location = new Point(126, 257);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(200, 23);
            StartDatePicker.TabIndex = 4;
            // 
            // NotesPrompt
            // 
            NotesPrompt.Location = new Point(126, 140);
            NotesPrompt.Multiline = true;
            NotesPrompt.Name = "NotesPrompt";
            NotesPrompt.Size = new Size(200, 56);
            NotesPrompt.TabIndex = 2;
            // 
            // DescriptionPrompt
            // 
            DescriptionPrompt.Location = new Point(126, 98);
            DescriptionPrompt.Name = "DescriptionPrompt";
            DescriptionPrompt.Size = new Size(200, 23);
            DescriptionPrompt.TabIndex = 1;
            // 
            // TopicPrompt
            // 
            TopicPrompt.Location = new Point(126, 56);
            TopicPrompt.Name = "TopicPrompt";
            TopicPrompt.Size = new Size(200, 23);
            TopicPrompt.TabIndex = 0;
            // 
            // AddConference
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 419);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Name = "AddConference";
            Text = "Yeni Konferans";
            Load += AddConference_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox UserSearchBar;
        private ListBox UsersListBox;
        private GroupBox groupBox4;
        private Label label11;
        private ComboBox UserRoleBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button AddParticipant;
        private RichTextBox UserAddressPrompt;
        private TextBox UserEmailPrompt;
        private TextBox UserGsmPrompt;
        private TextBox UserLastNamePrompt;
        private TextBox UserFirstNamePropmt;
        private GroupBox groupBox2;
        private DateTimePicker StartDatePicker;
        private TextBox NotesPrompt;
        private TextBox DescriptionPrompt;
        private TextBox TopicPrompt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox ConferenceRoomSelection;
        private DateTimePicker EndDatePicker;
        private Label label12;
        private Label label5;
        private Button CreateRequestButton;
    }
}