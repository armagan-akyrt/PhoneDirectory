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
            UsersList = new ListBox();
            label1 = new Label();
            label2 = new Label();
            ContactsList = new ListBox();
            btnBringContacts = new Button();
            UsersSearchBar = new TextBox();
            ContactsSearchBar = new TextBox();
            menuStrip1 = new MenuStrip();
            userToolStrip = new ToolStripMenuItem();
            UserViewStripMenuItem = new ToolStripMenuItem();
            NewUserMenuStrip = new ToolStripMenuItem();
            DeleteUserButton = new Button();
            DeletedUsersToolStrip = new ToolStripMenuItem();
            bağlantılarToolStripMenuItem = new ToolStripMenuItem();
            DeletedContactsToolStrip = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // UsersList
            // 
            UsersList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            UsersList.FormattingEnabled = true;
            UsersList.ItemHeight = 15;
            UsersList.Location = new Point(12, 72);
            UsersList.Name = "UsersList";
            UsersList.Size = new Size(336, 514);
            UsersList.TabIndex = 0;
            UsersList.SelectedIndexChanged += lsUsersList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcılar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 24);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 3;
            label2.Text = "Kullanıcının Rehberi:";
            // 
            // ContactsList
            // 
            ContactsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ContactsList.FormattingEnabled = true;
            ContactsList.ItemHeight = 15;
            ContactsList.Location = new Point(413, 71);
            ContactsList.Name = "ContactsList";
            ContactsList.Size = new Size(336, 544);
            ContactsList.TabIndex = 2;
            // 
            // btnBringContacts
            // 
            btnBringContacts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBringContacts.Location = new Point(273, 593);
            btnBringContacts.Name = "btnBringContacts";
            btnBringContacts.Size = new Size(75, 23);
            btnBringContacts.TabIndex = 4;
            btnBringContacts.Text = "Getir";
            btnBringContacts.UseVisualStyleBackColor = true;
            btnBringContacts.Click += btnBringContacts_Click;
            // 
            // UsersSearchBar
            // 
            UsersSearchBar.Location = new Point(12, 42);
            UsersSearchBar.Name = "UsersSearchBar";
            UsersSearchBar.Size = new Size(336, 23);
            UsersSearchBar.TabIndex = 5;
            UsersSearchBar.TextChanged += txtSearchUsers_TextChanged;
            // 
            // ContactsSearchBar
            // 
            ContactsSearchBar.Location = new Point(413, 42);
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
            // DeleteUserButton
            // 
            DeleteUserButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteUserButton.Location = new Point(12, 593);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(75, 23);
            DeleteUserButton.TabIndex = 9;
            DeleteUserButton.Text = "Sil";
            DeleteUserButton.UseVisualStyleBackColor = true;
            DeleteUserButton.Click += DeleteUserButton_Click;
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
            bağlantılarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DeletedContactsToolStrip });
            bağlantılarToolStripMenuItem.Name = "bağlantılarToolStripMenuItem";
            bağlantılarToolStripMenuItem.Size = new Size(75, 20);
            bağlantılarToolStripMenuItem.Text = "Bağlantılar";
            // 
            // DeletedContactsToolStrip
            // 
            DeletedContactsToolStrip.Name = "DeletedContactsToolStrip";
            DeletedContactsToolStrip.Size = new Size(180, 22);
            DeletedContactsToolStrip.Text = "Slinen Bağlantılar";
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 634);
            Controls.Add(DeleteUserButton);
            Controls.Add(ContactsSearchBar);
            Controls.Add(UsersSearchBar);
            Controls.Add(btnBringContacts);
            Controls.Add(label2);
            Controls.Add(ContactsList);
            Controls.Add(label1);
            Controls.Add(UsersList);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            Name = "AdminPage";
            Text = "AdminPage";
            Load += AdminPage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox UsersList;
        private Label label1;
        private Label label2;
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
    }
}