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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            richTextBox1 = new RichTextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(301, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(301, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 23);
            textBox2.TabIndex = 6;
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
            // textBox3
            // 
            textBox3.Location = new Point(301, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(239, 23);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
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
            // textBox4
            // 
            textBox4.Location = new Point(301, 240);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(239, 23);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
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
            // richTextBox1
            // 
            richTextBox1.Location = new Point(301, 303);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(239, 96);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // txtUpdatePerson
            // 
            txtUpdatePerson.Location = new Point(465, 412);
            txtUpdatePerson.Name = "txtUpdatePerson";
            txtUpdatePerson.Size = new Size(75, 23);
            txtUpdatePerson.TabIndex = 14;
            txtUpdatePerson.Text = "Güncelle";
            txtUpdatePerson.UseVisualStyleBackColor = true;
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
            Controls.Add(richTextBox1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private RichTextBox richTextBox1;
        private Button txtUpdatePerson;
        private TextBox txtSearchBar;
    }
}