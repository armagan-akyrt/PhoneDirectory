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
            lbContacts = new ListBox();
            label1 = new Label();
            btnAddPerson = new Button();
            label2 = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtGsm = new TextBox();
            label5 = new Label();
            label6 = new Label();
            rtAdress = new RichTextBox();
            txtUpdatePerson = new Button();
            txtSearchBar = new TextBox();
            SuspendLayout();
            // 
            // lbContacts
            // 
            lbContacts.FormattingEnabled = true;
            lbContacts.ItemHeight = 15;
            lbContacts.Location = new Point(12, 71);
            lbContacts.Name = "lbContacts";
            lbContacts.Size = new Size(268, 364);
            lbContacts.TabIndex = 0;
            lbContacts.SelectedIndexChanged += lbContacts_SelectedIndexChanged;
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
            // btnAddPerson
            // 
            btnAddPerson.Location = new Point(205, 9);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(75, 23);
            btnAddPerson.TabIndex = 2;
            btnAddPerson.Text = "Kişi Ekle";
            btnAddPerson.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 41);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 3;
            label2.Text = "Ad";
            label2.Click += label2_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(301, 59);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 23);
            txtName.TabIndex = 4;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(301, 116);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(239, 23);
            txtSurname.TabIndex = 6;
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
            // txtEmail
            // 
            txtEmail.Location = new Point(301, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 23);
            txtEmail.TabIndex = 8;
            txtEmail.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 154);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // txtGsm
            // 
            txtGsm.Location = new Point(301, 240);
            txtGsm.Name = "txtGsm";
            txtGsm.Size = new Size(239, 23);
            txtGsm.TabIndex = 10;
            txtGsm.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 222);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 9;
            label5.Text = "Numara";
            label5.Click += label5_Click;
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
            // rtAdress
            // 
            rtAdress.Location = new Point(301, 303);
            rtAdress.Name = "rtAdress";
            rtAdress.Size = new Size(239, 96);
            rtAdress.TabIndex = 13;
            rtAdress.Text = "";
            // 
            // txtUpdatePerson
            // 
            txtUpdatePerson.Location = new Point(465, 412);
            txtUpdatePerson.Name = "txtUpdatePerson";
            txtUpdatePerson.Size = new Size(75, 23);
            txtUpdatePerson.TabIndex = 14;
            txtUpdatePerson.Text = "Güncelle";
            txtUpdatePerson.UseVisualStyleBackColor = true;
            txtUpdatePerson.Click += txtUpdatePerson_Click;
            // 
            // txtSearchBar
            // 
            txtSearchBar.Location = new Point(12, 41);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.Size = new Size(268, 23);
            txtSearchBar.TabIndex = 15;
            txtSearchBar.TextChanged += txtSearchBar_TextChanged;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearchBar);
            Controls.Add(txtUpdatePerson);
            Controls.Add(rtAdress);
            Controls.Add(label6);
            Controls.Add(txtGsm);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtSurname);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(btnAddPerson);
            Controls.Add(label1);
            Controls.Add(lbContacts);
            Name = "UserPage";
            Text = "UserPage";
            Load += UserPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbContacts;
        private Label label1;
        private Button btnAddPerson;
        private Label label2;
        private TextBox txtName;
        private TextBox txtSurname;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtGsm;
        private Label label5;
        private Label label6;
        private RichTextBox rtAdress;
        private Button txtUpdatePerson;
        private TextBox txtSearchBar;
    }
}