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
            txtName = new TextBox();
            txtLastName = new TextBox();
            label2 = new Label();
            txtMail = new TextBox();
            label3 = new Label();
            txtGSM = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            rtxAdress = new RichTextBox();
            cbRole = new ComboBox();
            btnCreateUser = new Button();
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
            // txtName
            // 
            txtName.Location = new Point(12, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(222, 23);
            txtName.TabIndex = 1;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(12, 156);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(222, 23);
            txtLastName.TabIndex = 3;
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
            // txtMail
            // 
            txtMail.Location = new Point(12, 244);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(222, 23);
            txtMail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 226);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // txtGSM
            // 
            txtGSM.Location = new Point(12, 332);
            txtGSM.Name = "txtGSM";
            txtGSM.Size = new Size(222, 23);
            txtGSM.TabIndex = 7;
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
            label5.Location = new Point(319, 138);
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
            // rtxAdress
            // 
            rtxAdress.Location = new Point(319, 244);
            rtxAdress.Name = "rtxAdress";
            rtxAdress.Size = new Size(222, 111);
            rtxAdress.TabIndex = 12;
            rtxAdress.Text = "";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "ADMIN", "USER" });
            cbRole.Location = new Point(319, 156);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(222, 23);
            cbRole.TabIndex = 13;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(466, 393);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(75, 23);
            btnCreateUser.TabIndex = 14;
            btnCreateUser.Text = "Oluştur";
            btnCreateUser.UseVisualStyleBackColor = true;
            // 
            // CreateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateUser);
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
            Name = "CreateUser";
            Text = "CreateUser";
            Load += CreateUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtMail;
        private Label label3;
        private TextBox txtGSM;
        private Label label4;
        private Label label5;
        private Label label6;
        private RichTextBox rtxAdress;
        private ComboBox cbRole;
        private Button btnCreateUser;
    }
}