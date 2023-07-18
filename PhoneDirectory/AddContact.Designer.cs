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
            cbRole = new ComboBox();
            rtxAdress = new RichTextBox();
            label6 = new Label();
            label5 = new Label();
            txtGSM = new TextBox();
            label4 = new Label();
            txtMail = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            label7 = new Label();
            txtUser = new TextBox();
            SuspendLayout();
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(466, 419);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(75, 23);
            btnAddContact.TabIndex = 27;
            btnAddContact.Text = "Oluştur";
            btnAddContact.UseVisualStyleBackColor = true;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "ADMIN", "USER" });
            cbRole.Location = new Point(319, 182);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(222, 23);
            cbRole.TabIndex = 26;
            // 
            // rtxAdress
            // 
            rtxAdress.Location = new Point(319, 270);
            rtxAdress.Name = "rtxAdress";
            rtxAdress.Size = new Size(222, 111);
            rtxAdress.TabIndex = 25;
            rtxAdress.Text = "";
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
            // txtGSM
            // 
            txtGSM.Location = new Point(12, 358);
            txtGSM.Name = "txtGSM";
            txtGSM.Size = new Size(222, 23);
            txtGSM.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 340);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 21;
            label4.Text = "Telefon No.";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(12, 270);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(222, 23);
            txtMail.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 252);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 19;
            label3.Text = "Email";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(12, 182);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(222, 23);
            txtLastName.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 164);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 17;
            label2.Text = "Soyad";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 94);
            txtName.Name = "txtName";
            txtName.Size = new Size(222, 23);
            txtName.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 15;
            label1.Text = "Ad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 28;
            label7.Text = "Kişi:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(12, 27);
            txtUser.Name = "txtUser";
            txtUser.ReadOnly = true;
            txtUser.Size = new Size(222, 23);
            txtUser.TabIndex = 29;
            // 
            // AddContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUser);
            Controls.Add(label7);
            Controls.Add(btnAddContact);
            Controls.Add(cbRole);
            Controls.Add(rtxAdress);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtGSM);
            Controls.Add(label4);
            Controls.Add(txtMail);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "AddContact";
            Text = "AddContact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddContact;
        private ComboBox cbRole;
        private RichTextBox rtxAdress;
        private Label label6;
        private Label label5;
        private TextBox txtGSM;
        private Label label4;
        private TextBox txtMail;
        private Label label3;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Label label7;
        private TextBox txtUser;
    }
}