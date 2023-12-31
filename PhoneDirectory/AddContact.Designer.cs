﻿namespace PhoneDirectory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContact));
            btnAddContact = new Button();
            AddressPrompt = new RichTextBox();
            label6 = new Label();
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
            SuspendLayout();
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(472, 390);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(75, 23);
            btnAddContact.TabIndex = 27;
            btnAddContact.Text = "Oluştur";
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // AddressPrompt
            // 
            AddressPrompt.Location = new Point(325, 273);
            AddressPrompt.Name = "AddressPrompt";
            AddressPrompt.Size = new Size(222, 111);
            AddressPrompt.TabIndex = 25;
            AddressPrompt.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 255);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 24;
            label6.Text = "Adres";
            // 
            // GsmPrompt
            // 
            GsmPrompt.Location = new Point(12, 363);
            GsmPrompt.Name = "GsmPrompt";
            GsmPrompt.Size = new Size(222, 23);
            GsmPrompt.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 345);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 21;
            label4.Text = "Telefon No.";
            // 
            // EmailPrompt
            // 
            EmailPrompt.Location = new Point(12, 283);
            EmailPrompt.Name = "EmailPrompt";
            EmailPrompt.Size = new Size(222, 23);
            EmailPrompt.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 265);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 19;
            label3.Text = "Email";
            // 
            // SurnamePrompt
            // 
            SurnamePrompt.Location = new Point(12, 203);
            SurnamePrompt.Name = "SurnamePrompt";
            SurnamePrompt.Size = new Size(222, 23);
            SurnamePrompt.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 185);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 17;
            label2.Text = "Soyad";
            // 
            // NamePrompt
            // 
            NamePrompt.Location = new Point(12, 123);
            NamePrompt.Name = "NamePrompt";
            NamePrompt.Size = new Size(222, 23);
            NamePrompt.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 105);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 15;
            label1.Text = "Ad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 50);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 28;
            label7.Text = "Mevcut Kullanıcı:";
            // 
            // CurrentUserPrompt
            // 
            CurrentUserPrompt.Location = new Point(12, 68);
            CurrentUserPrompt.Name = "CurrentUserPrompt";
            CurrentUserPrompt.ReadOnly = true;
            CurrentUserPrompt.Size = new Size(222, 23);
            CurrentUserPrompt.TabIndex = 29;
            // 
            // AddContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 450);
            Controls.Add(CurrentUserPrompt);
            Controls.Add(label7);
            Controls.Add(btnAddContact);
            Controls.Add(AddressPrompt);
            Controls.Add(label6);
            Controls.Add(GsmPrompt);
            Controls.Add(label4);
            Controls.Add(EmailPrompt);
            Controls.Add(label3);
            Controls.Add(SurnamePrompt);
            Controls.Add(label2);
            Controls.Add(NamePrompt);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddContact";
            Text = "Bağlantı Ekle";
            Load += AddContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddContact;
        private RichTextBox AddressPrompt;
        private Label label6;
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
    }
}