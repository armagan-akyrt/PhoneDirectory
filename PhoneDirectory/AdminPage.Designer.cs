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
            button1 = new Button();
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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcılar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 8);
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
            // button1
            // 
            button1.Location = new Point(777, 565);
            button1.Name = "button1";
            button1.Size = new Size(92, 50);
            button1.TabIndex = 7;
            button1.Text = "Kullanıcı Görünümü";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 634);
            Controls.Add(button1);
            Controls.Add(txtSearchContacts);
            Controls.Add(txtSearchUsers);
            Controls.Add(btnBringContacts);
            Controls.Add(label2);
            Controls.Add(lstContacts);
            Controls.Add(label1);
            Controls.Add(lsUsersList);
            MinimizeBox = false;
            Name = "AdminPage";
            Text = "AdminPage";
            Load += AdminPage_Load;
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
        private Button button1;
    }
}