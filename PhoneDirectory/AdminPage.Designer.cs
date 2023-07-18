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
            lsUsersList = new ListBox();
            label1 = new Label();
            label2 = new Label();
            lstContacts = new ListBox();
            btnBringContacts = new Button();
            txtSearchUsers = new TextBox();
            txtSearchContacts = new TextBox();
            menuStrip1 = new MenuStrip();
            userToolStrip = new ToolStripMenuItem();
            UserViewStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lsUsersList
            // 
            lsUsersList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lsUsersList.FormattingEnabled = true;
            lsUsersList.ItemHeight = 15;
            lsUsersList.Location = new Point(12, 72);
            lsUsersList.Name = "lsUsersList";
            lsUsersList.Size = new Size(336, 514);
            lsUsersList.TabIndex = 0;
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
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Rehber:";
            // 
            // lstContacts
            // 
            lstContacts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstContacts.FormattingEnabled = true;
            lstContacts.ItemHeight = 15;
            lstContacts.Location = new Point(413, 71);
            lstContacts.Name = "lstContacts";
            lstContacts.Size = new Size(336, 544);
            lstContacts.TabIndex = 2;
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
            // 
            // txtSearchUsers
            // 
            txtSearchUsers.Location = new Point(12, 42);
            txtSearchUsers.Name = "txtSearchUsers";
            txtSearchUsers.Size = new Size(336, 23);
            txtSearchUsers.TabIndex = 5;
            txtSearchUsers.TextChanged += txtSearchUsers_TextChanged;
            // 
            // txtSearchContacts
            // 
            txtSearchContacts.Location = new Point(413, 42);
            txtSearchContacts.Name = "txtSearchContacts";
            txtSearchContacts.Size = new Size(336, 23);
            txtSearchContacts.TabIndex = 6;
            txtSearchContacts.TextChanged += txtSearchContacts_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1151, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // userToolStrip
            // 
            userToolStrip.DropDownItems.AddRange(new ToolStripItem[] { UserViewStripMenuItem });
            userToolStrip.Name = "userToolStrip";
            userToolStrip.Size = new Size(64, 20);
            userToolStrip.Text = "Kullanıcı";
            // 
            // UserViewStripMenuItem
            // 
            UserViewStripMenuItem.Name = "UserViewStripMenuItem";
            UserViewStripMenuItem.Size = new Size(180, 22);
            UserViewStripMenuItem.Text = "Kullanıcı Görünümü";
            UserViewStripMenuItem.Click += UserViewStripMenuItem_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 634);
            Controls.Add(txtSearchContacts);
            Controls.Add(txtSearchUsers);
            Controls.Add(btnBringContacts);
            Controls.Add(label2);
            Controls.Add(lstContacts);
            Controls.Add(label1);
            Controls.Add(lsUsersList);
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

        private ListBox lsUsersList;
        private Label label1;
        private Label label2;
        private ListBox lstContacts;
        private Button btnBringContacts;
        private TextBox txtSearchUsers;
        private TextBox txtSearchContacts;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem userToolStrip;
        private ToolStripMenuItem UserViewStripMenuItem;
    }
}