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
            label1 = new Label();
            AddPersonButton = new Button();
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
            SuspendLayout();
            // 
            // ContactsListBox
            // 
            ContactsListBox.FormattingEnabled = true;
            ContactsListBox.ItemHeight = 15;
            ContactsListBox.Location = new Point(12, 71);
            ContactsListBox.Name = "ContactsListBox";
            ContactsListBox.Size = new Size(268, 364);
            ContactsListBox.TabIndex = 0;
            ContactsListBox.SelectedIndexChanged += ContactsListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Kişiler:";
            // 
            // AddPersonButton
            // 
            AddPersonButton.Location = new Point(205, 9);
            AddPersonButton.Name = "AddPersonButton";
            AddPersonButton.Size = new Size(75, 23);
            AddPersonButton.TabIndex = 2;
            AddPersonButton.Text = "Kişi Ekle";
            AddPersonButton.UseVisualStyleBackColor = true;
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
            SearchBar.Location = new Point(12, 41);
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(268, 23);
            SearchBar.TabIndex = 15;
            SearchBar.TextChanged += SearchBar_TextChanged;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchBar);
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
            Controls.Add(AddPersonButton);
            Controls.Add(label1);
            Controls.Add(ContactsListBox);
            Name = "UserPage";
            Text = "UserPage";
            Load += UserPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ContactsListBox;
        private Label label1;
        private Button AddPersonButton;
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
    }
}