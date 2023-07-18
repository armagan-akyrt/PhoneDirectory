namespace PhoneDirectory
{
    partial class AddContact
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
            btnAddContact = new Button();
            RoleComboBox = new ComboBox();
            AddressPrompt = new RichTextBox();
            label6 = new Label();
            label5 = new Label();
            GsmPrompt = new TextBox();
            label4 = new Label();
            EmailPrompt = new TextBox();
            label3 = new Label();
            SurnamePrompt = new TextBox();
            label2 = new Label();
            NamePrompt = new TextBox();
            label1 = new Label();
            label7 = new Label();
            CurrentUserPrompt = new TextBox();
            ReturnToUserPageButton = new Button();
            SuspendLayout();
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(319, 410);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(75, 23);
            btnAddContact.TabIndex = 27;
            btnAddContact.Text = "Oluştur";
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // RoleComboBox
            // 
            RoleComboBox.FormattingEnabled = true;
            RoleComboBox.Items.AddRange(new object[] { "ADMIN", "USER" });
            RoleComboBox.Location = new Point(319, 182);
            RoleComboBox.Name = "RoleComboBox";
            RoleComboBox.Size = new Size(222, 23);
            RoleComboBox.TabIndex = 26;
            // 
            // AddressPrompt
            // 
            AddressPrompt.Location = new Point(319, 270);
            AddressPrompt.Name = "AddressPrompt";
            AddressPrompt.Size = new Size(222, 111);
            AddressPrompt.TabIndex = 25;
            AddressPrompt.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(319, 252);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 24;
            label6.Text = "Adres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(319, 164);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 23;
            label5.Text = "Rol";
            // 
            // GsmPrompt
            // 
            GsmPrompt.Location = new Point(12, 411);
            GsmPrompt.Name = "GsmPrompt";
            GsmPrompt.Size = new Size(222, 23);
            GsmPrompt.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 393);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 21;
            label4.Text = "Telefon No.";
            // 
            // EmailPrompt
            // 
            EmailPrompt.Location = new Point(12, 331);
            EmailPrompt.Name = "EmailPrompt";
            EmailPrompt.Size = new Size(222, 23);
            EmailPrompt.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 313);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 19;
            label3.Text = "Email";
            // 
            // SurnamePrompt
            // 
            SurnamePrompt.Location = new Point(12, 251);
            SurnamePrompt.Name = "SurnamePrompt";
            SurnamePrompt.Size = new Size(222, 23);
            SurnamePrompt.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 233);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 17;
            label2.Text = "Soyad";
            // 
            // NamePrompt
            // 
            NamePrompt.Location = new Point(12, 171);
            NamePrompt.Name = "NamePrompt";
            NamePrompt.Size = new Size(222, 23);
            NamePrompt.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 153);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 15;
            label1.Text = "Ad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 73);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 28;
            label7.Text = "Mevcut Kullanıcı:";
            // 
            // CurrentUserPrompt
            // 
            CurrentUserPrompt.Location = new Point(12, 91);
            CurrentUserPrompt.Name = "CurrentUserPrompt";
            CurrentUserPrompt.ReadOnly = true;
            CurrentUserPrompt.Size = new Size(222, 23);
            CurrentUserPrompt.TabIndex = 29;
            // 
            // ReturnToUserPageButton
            // 
            ReturnToUserPageButton.Location = new Point(466, 415);
            ReturnToUserPageButton.Name = "ReturnToUserPageButton";
            ReturnToUserPageButton.Size = new Size(75, 23);
            ReturnToUserPageButton.TabIndex = 30;
            ReturnToUserPageButton.Text = "Geri Dön";
            ReturnToUserPageButton.UseVisualStyleBackColor = true;
            ReturnToUserPageButton.Click += ReturnToUserPageButton_Click;
            // 
            // AddContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReturnToUserPageButton);
            Controls.Add(CurrentUserPrompt);
            Controls.Add(label7);
            Controls.Add(btnAddContact);
            Controls.Add(RoleComboBox);
            Controls.Add(AddressPrompt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(GsmPrompt);
            Controls.Add(label4);
            Controls.Add(EmailPrompt);
            Controls.Add(label3);
            Controls.Add(SurnamePrompt);
            Controls.Add(label2);
            Controls.Add(NamePrompt);
            Controls.Add(label1);
            Name = "AddContact";
            Text = "AddContact";
            Load += AddContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddContact;
        private ComboBox RoleComboBox;
        private RichTextBox AddressPrompt;
        private Label label6;
        private Label label5;
        private TextBox GsmPrompt;
        private Label label4;
        private TextBox EmailPrompt;
        private Label label3;
        private TextBox SurnamePrompt;
        private Label label2;
        private TextBox NamePrompt;
        private Label label1;
        private Label label7;
        private TextBox CurrentUserPrompt;
        private Button ReturnToUserPageButton;
    }
}