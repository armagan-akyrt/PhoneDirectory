namespace PhoneDirectory
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            UsersList = new ListBox();
            ContactsList = new ListBox();
            btnBringContacts = new Button();
            UsersSearchBar = new TextBox();
            ContactsSearchBar = new TextBox();
            menuStrip1 = new MenuStrip();
            userToolStrip = new ToolStripMenuItem();
            UserViewStripMenuItem = new ToolStripMenuItem();
            NewUserMenuStrip = new ToolStripMenuItem();
            DeletedUsersToolStrip = new ToolStripMenuItem();
            bağlantılarToolStripMenuItem = new ToolStripMenuItem();
            DeletedContactsToolStrip = new ToolStripMenuItem();
            NewContactToolstrip = new ToolStripMenuItem();
            DeleteUserButton = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            UpdateUserButton = new Button();
            AddressPrompt = new RichTextBox();
            EmailPrompt = new TextBox();
            GsmPrompt = new TextBox();
            LastNamePrompt = new TextBox();
            NamePrompt = new TextBox();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UsersList
            // 
            UsersList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            UsersList.FormattingEnabled = true;
            UsersList.ItemHeight = 15;
            UsersList.Location = new Point(25, 47);
            UsersList.Name = "UsersList";
            UsersList.Size = new Size(336, 514);
            UsersList.TabIndex = 0;
            UsersList.SelectedIndexChanged += lsUsersList_SelectedIndexChanged;
            // 
            // ContactsList
            // 
            ContactsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ContactsList.FormattingEnabled = true;
            ContactsList.ItemHeight = 15;
            ContactsList.Location = new Point(16, 51);
            ContactsList.Name = "ContactsList";
            ContactsList.Size = new Size(336, 529);
            ContactsList.TabIndex = 2;
            ContactsList.SelectedIndexChanged += ContactsList_SelectedIndexChanged;
            // 
            // btnBringContacts
            // 
            btnBringContacts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBringContacts.Location = new Point(286, 567);
            btnBringContacts.Name = "btnBringContacts";
            btnBringContacts.Size = new Size(75, 23);
            btnBringContacts.TabIndex = 4;
            btnBringContacts.Text = "Getir";
            btnBringContacts.UseVisualStyleBackColor = true;
            btnBringContacts.Click += btnBringContacts_Click;
            // 
            // UsersSearchBar
            // 
            UsersSearchBar.Location = new Point(25, 18);
            UsersSearchBar.Name = "UsersSearchBar";
            UsersSearchBar.Size = new Size(336, 23);
            UsersSearchBar.TabIndex = 5;
            UsersSearchBar.TextChanged += txtSearchUsers_TextChanged;
            // 
            // ContactsSearchBar
            // 
            ContactsSearchBar.Location = new Point(16, 22);
            ContactsSearchBar.Name = "ContactsSearchBar";
            ContactsSearchBar.Size = new Size(336, 23);
            ContactsSearchBar.TabIndex = 6;
            ContactsSearchBar.TextChanged += txtSearchContacts_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStrip, bağlantılarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1151, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // userToolStrip
            // 
            userToolStrip.DropDownItems.AddRange(new ToolStripItem[] { UserViewStripMenuItem, NewUserMenuStrip, DeletedUsersToolStrip });
            userToolStrip.Name = "userToolStrip";
            userToolStrip.Size = new Size(64, 20);
            userToolStrip.Text = "Kullanıcı";
            // 
            // UserViewStripMenuItem
            // 
            UserViewStripMenuItem.Name = "UserViewStripMenuItem";
            UserViewStripMenuItem.Size = new Size(186, 22);
            UserViewStripMenuItem.Text = "Kullanıcı Görünümü";
            UserViewStripMenuItem.Click += UserViewStripMenuItem_Click;
            // 
            // NewUserMenuStrip
            // 
            NewUserMenuStrip.Name = "NewUserMenuStrip";
            NewUserMenuStrip.Size = new Size(186, 22);
            NewUserMenuStrip.Text = "Yeni Kullanıcı Oluştur";
            NewUserMenuStrip.Click += NewUserMenuStrip_Click;
            // 
            // DeletedUsersToolStrip
            // 
            DeletedUsersToolStrip.Name = "DeletedUsersToolStrip";
            DeletedUsersToolStrip.Size = new Size(186, 22);
            DeletedUsersToolStrip.Text = "Silinen Kullanıcılar";
            DeletedUsersToolStrip.Click += DeletedUsersToolStrip_Click;
            // 
            // bağlantılarToolStripMenuItem
            // 
            bağlantılarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DeletedContactsToolStrip, NewContactToolstrip });
            bağlantılarToolStripMenuItem.Name = "bağlantılarToolStripMenuItem";
            bağlantılarToolStripMenuItem.Size = new Size(75, 20);
            bağlantılarToolStripMenuItem.Text = "Bağlantılar";
            // 
            // DeletedContactsToolStrip
            // 
            DeletedContactsToolStrip.Name = "DeletedContactsToolStrip";
            DeletedContactsToolStrip.Size = new Size(165, 22);
            DeletedContactsToolStrip.Text = "Slinen Bağlantılar";
            DeletedContactsToolStrip.Click += DeletedContactsToolStrip_Click;
            // 
            // NewContactToolstrip
            // 
            NewContactToolstrip.Name = "NewContactToolstrip";
            NewContactToolstrip.Size = new Size(165, 22);
            NewContactToolstrip.Text = "Yeni Bağlantı";
            NewContactToolstrip.Click += NewContactToolstrip_Click;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteUserButton.Location = new Point(25, 567);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(75, 23);
            DeleteUserButton.TabIndex = 9;
            DeleteUserButton.Text = "Sil";
            DeleteUserButton.UseVisualStyleBackColor = true;
            DeleteUserButton.Click += DeleteUserButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(btnBringContacts);
            groupBox1.Controls.Add(DeleteUserButton);
            groupBox1.Controls.Add(UsersSearchBar);
            groupBox1.Controls.Add(UsersList);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 598);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Ara:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(ContactsList);
            groupBox2.Controls.Add(ContactsSearchBar);
            groupBox2.Location = new Point(457, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(367, 595);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kullanıcının Rehberinde Ara:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(UpdateUserButton);
            groupBox3.Controls.Add(AddressPrompt);
            groupBox3.Controls.Add(EmailPrompt);
            groupBox3.Controls.Add(GsmPrompt);
            groupBox3.Controls.Add(LastNamePrompt);
            groupBox3.Controls.Add(NamePrompt);
            groupBox3.Location = new Point(830, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(309, 389);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Bağlantı Bilgileri:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 239);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 10;
            label5.Text = "Adres:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 200);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 9;
            label4.Text = "E-posta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 153);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 8;
            label3.Text = "Tel. No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 106);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 7;
            label2.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 59);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 6;
            label1.Text = "Ad:";
            // 
            // UpdateUserButton
            // 
            UpdateUserButton.Location = new Point(214, 354);
            UpdateUserButton.Name = "UpdateUserButton";
            UpdateUserButton.Size = new Size(75, 23);
            UpdateUserButton.TabIndex = 5;
            UpdateUserButton.Text = "Güncelle";
            UpdateUserButton.UseVisualStyleBackColor = true;
            UpdateUserButton.Click += UpdateUserButton_Click;
            // 
            // AddressPrompt
            // 
            AddressPrompt.Location = new Point(69, 239);
            AddressPrompt.Name = "AddressPrompt";
            AddressPrompt.Size = new Size(220, 109);
            AddressPrompt.TabIndex = 4;
            AddressPrompt.Text = "";
            // 
            // EmailPrompt
            // 
            EmailPrompt.Location = new Point(69, 192);
            EmailPrompt.Name = "EmailPrompt";
            EmailPrompt.Size = new Size(220, 23);
            EmailPrompt.TabIndex = 3;
            // 
            // GsmPrompt
            // 
            GsmPrompt.Location = new Point(69, 145);
            GsmPrompt.Name = "GsmPrompt";
            GsmPrompt.Size = new Size(220, 23);
            GsmPrompt.TabIndex = 2;
            // 
            // LastNamePrompt
            // 
            LastNamePrompt.Location = new Point(69, 98);
            LastNamePrompt.Name = "LastNamePrompt";
            LastNamePrompt.Size = new Size(220, 23);
            LastNamePrompt.TabIndex = 1;
            // 
            // NamePrompt
            // 
            NamePrompt.Location = new Point(69, 51);
            NamePrompt.Name = "NamePrompt";
            NamePrompt.Size = new Size(220, 23);
            NamePrompt.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.ImageLocation = "C:\\Users\\MONSTER\\source\\repos\\PhoneDirectory\\PhoneDirectory\\Assets\\logo.png";
            pictureBox1.Location = new Point(830, 422);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 634);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            Name = "AdminPage";
            Text = "Yönetici Sayfası";
            FormClosing += AdminPage_FormClosing;
            Load += AdminPage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox UsersList;
        private ListBox ContactsList;
        private Button btnBringContacts;
        private TextBox UsersSearchBar;
        private TextBox ContactsSearchBar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem userToolStrip;
        private ToolStripMenuItem UserViewStripMenuItem;
        private ToolStripMenuItem NewUserMenuStrip;
        private Button DeleteUserButton;
        private ToolStripMenuItem DeletedUsersToolStrip;
        private ToolStripMenuItem bağlantılarToolStripMenuItem;
        private ToolStripMenuItem DeletedContactsToolStrip;
        private ToolStripMenuItem NewContactToolstrip;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Button UpdateUserButton;
        private RichTextBox AddressPrompt;
        private TextBox EmailPrompt;
        private TextBox GsmPrompt;
        private TextBox LastNamePrompt;
        private TextBox NamePrompt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
    }
}