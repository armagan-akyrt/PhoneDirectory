namespace PhoneDirectory
{
    partial class UserPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPage));
            ContactsListBox = new ListBox();
            label2 = new Label();
            NamePrompt = new TextBox();
            SurnamePromp = new TextBox();
            label3 = new Label();
            EmailPrompt = new TextBox();
            label4 = new Label();
            GsmPrompt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            AddresPrompt = new RichTextBox();
            UpdateContactButton = new Button();
            SearchBar = new TextBox();
            menuStrip1 = new MenuStrip();
            PersonToolStrip = new ToolStripMenuItem();
            AddPersonToolStrip = new ToolStripMenuItem();
            DeletedContactsToolStrip = new ToolStripMenuItem();
            AdminToolStrip = new ToolStripMenuItem();
            AdminToolStripMenu = new ToolStripMenuItem();
            ChangePasswordStripTool = new ToolStripMenuItem();
            toplantılarToolStripMenuItem = new ToolStripMenuItem();
            AddMeetingToolStrip = new ToolStripMenuItem();
            DeletedMeetingsToolStrip = new ToolStripMenuItem();
            DeleteButton = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            GuestMeetingsList = new ListBox();
            MeetingsSearchBar = new TextBox();
            UpcomingMeetingsList = new ListBox();
            DeleteMeetingButton = new Button();
            UpdateMeetingButton = new Button();
            NotesPrompt = new RichTextBox();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            fullNamePrompt = new TextBox();
            label10 = new Label();
            StartTimePicker = new DateTimePicker();
            EndTimePicker = new DateTimePicker();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ContactsListBox
            // 
            ContactsListBox.FormattingEnabled = true;
            ContactsListBox.ItemHeight = 15;
            ContactsListBox.Location = new Point(12, 55);
            ContactsListBox.Name = "ContactsListBox";
            ContactsListBox.Size = new Size(268, 349);
            ContactsListBox.TabIndex = 0;
            ContactsListBox.SelectedIndexChanged += ContactsListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 41);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 3;
            label2.Text = "Ad";
            // 
            // NamePrompt
            // 
            NamePrompt.Location = new Point(301, 59);
            NamePrompt.Name = "NamePrompt";
            NamePrompt.Size = new Size(239, 23);
            NamePrompt.TabIndex = 4;
            // 
            // SurnamePromp
            // 
            SurnamePromp.Location = new Point(301, 116);
            SurnamePromp.Name = "SurnamePromp";
            SurnamePromp.Size = new Size(239, 23);
            SurnamePromp.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 98);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Soyad";
            // 
            // EmailPrompt
            // 
            EmailPrompt.Location = new Point(301, 172);
            EmailPrompt.Name = "EmailPrompt";
            EmailPrompt.Size = new Size(239, 23);
            EmailPrompt.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 154);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // GsmPrompt
            // 
            GsmPrompt.Location = new Point(301, 240);
            GsmPrompt.Name = "GsmPrompt";
            GsmPrompt.Size = new Size(239, 23);
            GsmPrompt.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 222);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 9;
            label5.Text = "Numara";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 285);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 11;
            label6.Text = "Adres";
            // 
            // AddresPrompt
            // 
            AddresPrompt.Location = new Point(301, 303);
            AddresPrompt.Name = "AddresPrompt";
            AddresPrompt.Size = new Size(239, 96);
            AddresPrompt.TabIndex = 13;
            AddresPrompt.Text = "";
            // 
            // UpdateContactButton
            // 
            UpdateContactButton.Location = new Point(465, 412);
            UpdateContactButton.Name = "UpdateContactButton";
            UpdateContactButton.Size = new Size(75, 23);
            UpdateContactButton.TabIndex = 14;
            UpdateContactButton.Text = "Güncelle";
            UpdateContactButton.UseVisualStyleBackColor = true;
            UpdateContactButton.Click += UpdatePerson_Click;
            // 
            // SearchBar
            // 
            SearchBar.Location = new Point(12, 26);
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(268, 23);
            SearchBar.TabIndex = 15;
            SearchBar.TextChanged += SearchBar_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { PersonToolStrip, AdminToolStrip, ChangePasswordStripTool, toplantılarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1101, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "MenuStrip";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // PersonToolStrip
            // 
            PersonToolStrip.DropDownItems.AddRange(new ToolStripItem[] { AddPersonToolStrip, DeletedContactsToolStrip });
            PersonToolStrip.Name = "PersonToolStrip";
            PersonToolStrip.Size = new Size(75, 20);
            PersonToolStrip.Text = "Bağlantılar";
            // 
            // AddPersonToolStrip
            // 
            AddPersonToolStrip.Name = "AddPersonToolStrip";
            AddPersonToolStrip.Size = new Size(168, 22);
            AddPersonToolStrip.Text = "Bağlantı Ekle";
            AddPersonToolStrip.Click += AddPersonToolStrip_Click;
            // 
            // DeletedContactsToolStrip
            // 
            DeletedContactsToolStrip.Name = "DeletedContactsToolStrip";
            DeletedContactsToolStrip.Size = new Size(168, 22);
            DeletedContactsToolStrip.Text = "Silinen Bağlantılar";
            DeletedContactsToolStrip.Click += DeletedContactsToolStrip_Click;
            // 
            // AdminToolStrip
            // 
            AdminToolStrip.DropDownItems.AddRange(new ToolStripItem[] { AdminToolStripMenu });
            AdminToolStrip.Name = "AdminToolStrip";
            AdminToolStrip.Size = new Size(61, 20);
            AdminToolStrip.Text = "Yönetici";
            // 
            // AdminToolStripMenu
            // 
            AdminToolStripMenu.Name = "AdminToolStripMenu";
            AdminToolStripMenu.Size = new Size(151, 22);
            AdminToolStripMenu.Text = "Yönetici Ekranı";
            AdminToolStripMenu.Click += AdminToolStripMenu_Click;
            // 
            // ChangePasswordStripTool
            // 
            ChangePasswordStripTool.Name = "ChangePasswordStripTool";
            ChangePasswordStripTool.Size = new Size(85, 20);
            ChangePasswordStripTool.Text = "Şifre Değiştir";
            ChangePasswordStripTool.Click += ChangePasswordStripTool_Click;
            // 
            // toplantılarToolStripMenuItem
            // 
            toplantılarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddMeetingToolStrip, DeletedMeetingsToolStrip });
            toplantılarToolStripMenuItem.Name = "toplantılarToolStripMenuItem";
            toplantılarToolStripMenuItem.Size = new Size(74, 20);
            toplantılarToolStripMenuItem.Text = "Toplantılar";
            // 
            // AddMeetingToolStrip
            // 
            AddMeetingToolStrip.Name = "AddMeetingToolStrip";
            AddMeetingToolStrip.Size = new Size(167, 22);
            AddMeetingToolStrip.Text = "Toplantı Ekle";
            AddMeetingToolStrip.Click += AddMeetingToolStrip_Click;
            // 
            // DeletedMeetingsToolStrip
            // 
            DeletedMeetingsToolStrip.Name = "DeletedMeetingsToolStrip";
            DeletedMeetingsToolStrip.Size = new Size(167, 22);
            DeletedMeetingsToolStrip.Text = "Silinen Toplantılar";
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(301, 412);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 18;
            DeleteButton.Text = "Sil";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ContactsListBox);
            groupBox1.Controls.Add(SearchBar);
            groupBox1.Location = new Point(0, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 422);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rehber:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(GuestMeetingsList);
            groupBox2.Controls.Add(MeetingsSearchBar);
            groupBox2.Controls.Add(UpcomingMeetingsList);
            groupBox2.Location = new Point(546, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(295, 420);
            groupBox2.TabIndex = 16;
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
            // DeleteMeetingButton
            // 
            DeleteMeetingButton.Location = new Point(847, 412);
            DeleteMeetingButton.Name = "DeleteMeetingButton";
            DeleteMeetingButton.Size = new Size(75, 23);
            DeleteMeetingButton.TabIndex = 31;
            DeleteMeetingButton.Text = "Sil";
            DeleteMeetingButton.UseVisualStyleBackColor = true;
            // 
            // UpdateMeetingButton
            // 
            UpdateMeetingButton.Location = new Point(1011, 412);
            UpdateMeetingButton.Name = "UpdateMeetingButton";
            UpdateMeetingButton.Size = new Size(75, 23);
            UpdateMeetingButton.TabIndex = 30;
            UpdateMeetingButton.Text = "Güncelle";
            UpdateMeetingButton.UseVisualStyleBackColor = true;
            UpdateMeetingButton.Click += UpdateMeetingButton_Click;
            // 
            // NotesPrompt
            // 
            NotesPrompt.Location = new Point(847, 222);
            NotesPrompt.Name = "NotesPrompt";
            NotesPrompt.Size = new Size(239, 177);
            NotesPrompt.TabIndex = 29;
            NotesPrompt.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(847, 204);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 28;
            label1.Text = "Not";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(847, 151);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 26;
            label7.Text = "Bitiş";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(847, 95);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 24;
            label8.Text = "Başlangıç";
            // 
            // fullNamePrompt
            // 
            fullNamePrompt.Location = new Point(847, 59);
            fullNamePrompt.Name = "fullNamePrompt";
            fullNamePrompt.Size = new Size(239, 23);
            fullNamePrompt.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(847, 41);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 20;
            label10.Text = "Ad Soyad";
            // 
            // StartTimePicker
            // 
            StartTimePicker.CustomFormat = "dd/MM/yy - HH.mm";
            StartTimePicker.Format = DateTimePickerFormat.Custom;
            StartTimePicker.Location = new Point(847, 113);
            StartTimePicker.Name = "StartTimePicker";
            StartTimePicker.Size = new Size(239, 23);
            StartTimePicker.TabIndex = 32;
            // 
            // EndTimePicker
            // 
            EndTimePicker.CustomFormat = "dd/MM/yy - HH.mm";
            EndTimePicker.Format = DateTimePickerFormat.Custom;
            EndTimePicker.Location = new Point(847, 169);
            EndTimePicker.Name = "EndTimePicker";
            EndTimePicker.Size = new Size(239, 23);
            EndTimePicker.TabIndex = 33;
            EndTimePicker.ValueChanged += EndTimePicker_ValueChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 6000;
            timer1.Tick += timer1_Tick;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 454);
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
            Controls.Add(groupBox1);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateContactButton);
            Controls.Add(AddresPrompt);
            Controls.Add(label6);
            Controls.Add(GsmPrompt);
            Controls.Add(label5);
            Controls.Add(EmailPrompt);
            Controls.Add(label4);
            Controls.Add(SurnamePromp);
            Controls.Add(label3);
            Controls.Add(NamePrompt);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserPage";
            Text = "Kullanıcı Ekranı";
            FormClosing += UserPage_FormClosing;
            Load += UserPage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ContactsListBox;
        private Label label2;
        private TextBox NamePrompt;
        private TextBox SurnamePromp;
        private Label label3;
        private TextBox EmailPrompt;
        private Label label4;
        private TextBox GsmPrompt;
        private Label label5;
        private Label label6;
        private RichTextBox AddresPrompt;
        private Button UpdateContactButton;
        private TextBox SearchBar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem PersonToolStrip;
        private ToolStripMenuItem AddPersonToolStrip;
        private Button DeleteButton;
        private ToolStripMenuItem AdminToolStrip;
        private ToolStripMenuItem AdminToolStripMenu;
        private ToolStripMenuItem DeletedContactsToolStrip;
        private GroupBox groupBox1;
        private ToolStripMenuItem ChangePasswordStripTool;
        private GroupBox groupBox2;
        private TextBox MeetingsSearchBar;
        private ListBox UpcomingMeetingsList;
        private Button DeleteMeetingButton;
        private Button UpdateMeetingButton;
        private RichTextBox NotesPrompt;
        private Label label1;
        private Label label7;
        private Label label8;
        private TextBox fullNamePrompt;
        private Label label10;
        private DateTimePicker StartTimePicker;
        private DateTimePicker EndTimePicker;
        private ListBox GuestMeetingsList;
        private ToolStripMenuItem toplantılarToolStripMenuItem;
        private ToolStripMenuItem AddMeetingToolStrip;
        private ToolStripMenuItem DeletedMeetingsToolStrip;
        private System.Windows.Forms.Timer timer1;
    }
}