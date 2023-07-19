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
            DeleteButton = new Button();
            groupBox1 = new GroupBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { PersonToolStrip, AdminToolStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(573, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "MenuStrip";
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
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 454);
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
            Name = "UserPage";
            Text = "Kullanıcı Ekranı";
            Load += UserPage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}