namespace PhoneDirectory
{
    partial class CreateUser
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
            label1 = new Label();
            FirstNamePrompt = new TextBox();
            LastNamePrompt = new TextBox();
            label2 = new Label();
            EmailPrompt = new TextBox();
            label3 = new Label();
            GsmPrompt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            AddressPrompt = new RichTextBox();
            RoleComboBox = new ComboBox();
            CreateUserButton = new Button();
            RegeneratePassword = new Button();
            PasswordPrompt = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // FirstNamePrompt
            // 
            FirstNamePrompt.Location = new Point(12, 68);
            FirstNamePrompt.Name = "FirstNamePrompt";
            FirstNamePrompt.Size = new Size(222, 23);
            FirstNamePrompt.TabIndex = 1;
            // 
            // LastNamePrompt
            // 
            LastNamePrompt.Location = new Point(12, 156);
            LastNamePrompt.Name = "LastNamePrompt";
            LastNamePrompt.Size = new Size(222, 23);
            LastNamePrompt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Soyad";
            // 
            // EmailPrompt
            // 
            EmailPrompt.Location = new Point(12, 244);
            EmailPrompt.Name = "EmailPrompt";
            EmailPrompt.Size = new Size(222, 23);
            EmailPrompt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 226);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // GsmPrompt
            // 
            GsmPrompt.Location = new Point(12, 332);
            GsmPrompt.Name = "GsmPrompt";
            GsmPrompt.Size = new Size(222, 23);
            GsmPrompt.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 314);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefon No.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(319, 182);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 8;
            label5.Text = "Rol";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(319, 226);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 10;
            label6.Text = "Adres";
            // 
            // AddressPrompt
            // 
            AddressPrompt.Location = new Point(319, 244);
            AddressPrompt.Name = "AddressPrompt";
            AddressPrompt.Size = new Size(222, 111);
            AddressPrompt.TabIndex = 12;
            AddressPrompt.Text = "";
            // 
            // RoleComboBox
            // 
            RoleComboBox.FormattingEnabled = true;
            RoleComboBox.Items.AddRange(new object[] { "ADMIN", "USER" });
            RoleComboBox.Location = new Point(319, 200);
            RoleComboBox.Name = "RoleComboBox";
            RoleComboBox.Size = new Size(222, 23);
            RoleComboBox.TabIndex = 13;
            // 
            // CreateUserButton
            // 
            CreateUserButton.Location = new Point(466, 393);
            CreateUserButton.Name = "CreateUserButton";
            CreateUserButton.Size = new Size(75, 23);
            CreateUserButton.TabIndex = 14;
            CreateUserButton.Text = "Oluştur";
            CreateUserButton.UseVisualStyleBackColor = true;
            CreateUserButton.Click += CreateUserButton_Click;
            // 
            // RegeneratePassword
            // 
            RegeneratePassword.Location = new Point(432, 156);
            RegeneratePassword.Name = "RegeneratePassword";
            RegeneratePassword.Size = new Size(111, 23);
            RegeneratePassword.TabIndex = 36;
            RegeneratePassword.Text = "Yeniden Oluştur";
            RegeneratePassword.UseVisualStyleBackColor = true;
            RegeneratePassword.Click += RegeneratePassword_Click;
            // 
            // PasswordPrompt
            // 
            PasswordPrompt.Location = new Point(319, 156);
            PasswordPrompt.Name = "PasswordPrompt";
            PasswordPrompt.ReadOnly = true;
            PasswordPrompt.Size = new Size(107, 23);
            PasswordPrompt.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(319, 138);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 34;
            label8.Text = "Şifte";
            // 
            // CreateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RegeneratePassword);
            Controls.Add(PasswordPrompt);
            Controls.Add(label8);
            Controls.Add(CreateUserButton);
            Controls.Add(RoleComboBox);
            Controls.Add(AddressPrompt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(GsmPrompt);
            Controls.Add(label4);
            Controls.Add(EmailPrompt);
            Controls.Add(label3);
            Controls.Add(LastNamePrompt);
            Controls.Add(label2);
            Controls.Add(FirstNamePrompt);
            Controls.Add(label1);
            Name = "CreateUser";
            Text = "Kullanıcı Oluştur";
            Load += CreateUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FirstNamePrompt;
        private TextBox LastNamePrompt;
        private Label label2;
        private TextBox EmailPrompt;
        private Label label3;
        private TextBox GsmPrompt;
        private Label label4;
        private Label label5;
        private Label label6;
        private RichTextBox AddressPrompt;
        private ComboBox RoleComboBox;
        private Button CreateUserButton;
        private Button RegeneratePassword;
        private TextBox PasswordPrompt;
        private Label label8;
    }
}