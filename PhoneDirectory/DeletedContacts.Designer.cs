namespace PhoneDirectory
{
    partial class DeletedContacts
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
            label2 = new Label();
            ContactsSearchBar = new TextBox();
            DeletedContactsList = new ListBox();
            UpdateAndBringButton = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            AddressPrompt = new RichTextBox();
            EmailPrompt = new TextBox();
            GsmPrompt = new TextBox();
            LastNamePrompt = new TextBox();
            FirstNamePrompt = new TextBox();
            DeletePermenantlyButton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 8;
            label2.Text = "Silinen Bağlantılar:";
            // 
            // ContactsSearchBar
            // 
            ContactsSearchBar.Location = new Point(12, 62);
            ContactsSearchBar.Name = "ContactsSearchBar";
            ContactsSearchBar.Size = new Size(265, 23);
            ContactsSearchBar.TabIndex = 7;
            ContactsSearchBar.TextChanged += ContactsSearchBar_TextChanged;
            // 
            // DeletedContactsList
            // 
            DeletedContactsList.FormattingEnabled = true;
            DeletedContactsList.ItemHeight = 15;
            DeletedContactsList.Location = new Point(12, 91);
            DeletedContactsList.Name = "DeletedContactsList";
            DeletedContactsList.Size = new Size(265, 349);
            DeletedContactsList.TabIndex = 6;
            DeletedContactsList.SelectedIndexChanged += DeletedContactsList_SelectedIndexChanged;
            // 
            // UpdateAndBringButton
            // 
            UpdateAndBringButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UpdateAndBringButton.AutoSize = true;
            UpdateAndBringButton.Location = new Point(461, 403);
            UpdateAndBringButton.Name = "UpdateAndBringButton";
            UpdateAndBringButton.Size = new Size(130, 25);
            UpdateAndBringButton.TabIndex = 38;
            UpdateAndBringButton.Text = "Güncelle ve Geri Getir";
            UpdateAndBringButton.UseVisualStyleBackColor = true;
            UpdateAndBringButton.Click += UpdateAndBringButton_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(302, 255);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 37;
            label6.Text = "Adres:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(302, 206);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 36;
            label5.Text = "E-posta:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(302, 157);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 35;
            label4.Text = "Telefon No:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(302, 107);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 34;
            label3.Text = "Soyad:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(302, 58);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 33;
            label1.Text = "Ad:";
            // 
            // AddressPrompt
            // 
            AddressPrompt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddressPrompt.Location = new Point(375, 252);
            AddressPrompt.Name = "AddressPrompt";
            AddressPrompt.Size = new Size(216, 132);
            AddressPrompt.TabIndex = 32;
            AddressPrompt.Text = "";
            // 
            // EmailPrompt
            // 
            EmailPrompt.Anchor = AnchorStyles.Right;
            EmailPrompt.Location = new Point(375, 198);
            EmailPrompt.Name = "EmailPrompt";
            EmailPrompt.Size = new Size(216, 23);
            EmailPrompt.TabIndex = 31;
            // 
            // GsmPrompt
            // 
            GsmPrompt.Anchor = AnchorStyles.Right;
            GsmPrompt.Location = new Point(375, 149);
            GsmPrompt.Name = "GsmPrompt";
            GsmPrompt.Size = new Size(216, 23);
            GsmPrompt.TabIndex = 30;
            // 
            // LastNamePrompt
            // 
            LastNamePrompt.Anchor = AnchorStyles.Right;
            LastNamePrompt.Location = new Point(375, 99);
            LastNamePrompt.Name = "LastNamePrompt";
            LastNamePrompt.Size = new Size(216, 23);
            LastNamePrompt.TabIndex = 29;
            // 
            // FirstNamePrompt
            // 
            FirstNamePrompt.Anchor = AnchorStyles.Right;
            FirstNamePrompt.Location = new Point(375, 50);
            FirstNamePrompt.Name = "FirstNamePrompt";
            FirstNamePrompt.Size = new Size(216, 23);
            FirstNamePrompt.TabIndex = 28;
            // 
            // DeletePermenantlyButton
            // 
            DeletePermenantlyButton.Location = new Point(375, 404);
            DeletePermenantlyButton.Name = "DeletePermenantlyButton";
            DeletePermenantlyButton.Size = new Size(75, 23);
            DeletePermenantlyButton.TabIndex = 27;
            DeletePermenantlyButton.Text = "Sil";
            DeletePermenantlyButton.UseVisualStyleBackColor = true;
            DeletePermenantlyButton.Click += DeletePermenantlyButton_Click;
            // 
            // DeletedContacts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 450);
            Controls.Add(UpdateAndBringButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(AddressPrompt);
            Controls.Add(EmailPrompt);
            Controls.Add(GsmPrompt);
            Controls.Add(LastNamePrompt);
            Controls.Add(FirstNamePrompt);
            Controls.Add(DeletePermenantlyButton);
            Controls.Add(label2);
            Controls.Add(ContactsSearchBar);
            Controls.Add(DeletedContactsList);
            Name = "DeletedContacts";
            Text = "DeletedContacts";
            Load += DeletedContacts_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox ContactsSearchBar;
        private ListBox DeletedContactsList;
        private Button UpdateAndBringButton;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private RichTextBox AddressPrompt;
        private TextBox EmailPrompt;
        private TextBox GsmPrompt;
        private TextBox LastNamePrompt;
        private TextBox FirstNamePrompt;
        private Button DeletePermenantlyButton;
    }
}