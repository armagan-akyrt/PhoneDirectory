namespace PhoneDirectory
{
    partial class DeletedUsersPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletedUsersPanel));
            DeletedUsersList = new ListBox();
            UsersSearchBar = new TextBox();
            label1 = new Label();
            DeletePermenantlyButton = new Button();
            UpdateAndBringButton = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            AddressPrompt = new RichTextBox();
            EmailPrompt = new TextBox();
            GsmPrompt = new TextBox();
            LastNamePrompt = new TextBox();
            FirstNamePrompt = new TextBox();
            SuspendLayout();
            // 
            // DeletedUsersList
            // 
            DeletedUsersList.FormattingEnabled = true;
            DeletedUsersList.ItemHeight = 15;
            DeletedUsersList.Location = new Point(12, 83);
            DeletedUsersList.Name = "DeletedUsersList";
            DeletedUsersList.Size = new Size(265, 349);
            DeletedUsersList.TabIndex = 0;
            DeletedUsersList.SelectedIndexChanged += DeletedUsersList_SelectedIndexChanged;
            // 
            // UsersSearchBar
            // 
            UsersSearchBar.Location = new Point(12, 54);
            UsersSearchBar.Name = "UsersSearchBar";
            UsersSearchBar.Size = new Size(265, 23);
            UsersSearchBar.TabIndex = 1;
            UsersSearchBar.TextChanged += UsersSearchBar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 2;
            label1.Text = "Silinen Kullanıcılar:";
            // 
            // DeletePermenantlyButton
            // 
            DeletePermenantlyButton.Location = new Point(399, 408);
            DeletePermenantlyButton.Name = "DeletePermenantlyButton";
            DeletePermenantlyButton.Size = new Size(75, 23);
            DeletePermenantlyButton.TabIndex = 14;
            DeletePermenantlyButton.Text = "Sil";
            DeletePermenantlyButton.UseVisualStyleBackColor = true;
            DeletePermenantlyButton.Click += DeletePermenantlyButton_Click;
            // 
            // UpdateAndBringButton
            // 
            UpdateAndBringButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UpdateAndBringButton.AutoSize = true;
            UpdateAndBringButton.Location = new Point(485, 407);
            UpdateAndBringButton.Name = "UpdateAndBringButton";
            UpdateAndBringButton.Size = new Size(130, 25);
            UpdateAndBringButton.TabIndex = 26;
            UpdateAndBringButton.Text = "Güncelle ve Geri Getir";
            UpdateAndBringButton.UseVisualStyleBackColor = true;
            UpdateAndBringButton.Click += UpdateAndBringButton_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(326, 259);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 25;
            label6.Text = "Adres:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(326, 210);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 24;
            label5.Text = "E-posta:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(326, 161);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 23;
            label4.Text = "Telefon No:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(326, 111);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 22;
            label3.Text = "Soyad:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(326, 62);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 21;
            label2.Text = "Ad:";
            // 
            // AddressPrompt
            // 
            AddressPrompt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddressPrompt.Location = new Point(399, 256);
            AddressPrompt.Name = "AddressPrompt";
            AddressPrompt.Size = new Size(216, 132);
            AddressPrompt.TabIndex = 20;
            AddressPrompt.Text = "";
            // 
            // EmailPrompt
            // 
            EmailPrompt.Anchor = AnchorStyles.Right;
            EmailPrompt.Location = new Point(399, 202);
            EmailPrompt.Name = "EmailPrompt";
            EmailPrompt.Size = new Size(216, 23);
            EmailPrompt.TabIndex = 19;
            // 
            // GsmPrompt
            // 
            GsmPrompt.Anchor = AnchorStyles.Right;
            GsmPrompt.Location = new Point(399, 153);
            GsmPrompt.Name = "GsmPrompt";
            GsmPrompt.Size = new Size(216, 23);
            GsmPrompt.TabIndex = 18;
            // 
            // LastNamePrompt
            // 
            LastNamePrompt.Anchor = AnchorStyles.Right;
            LastNamePrompt.Location = new Point(399, 103);
            LastNamePrompt.Name = "LastNamePrompt";
            LastNamePrompt.Size = new Size(216, 23);
            LastNamePrompt.TabIndex = 17;
            // 
            // FirstNamePrompt
            // 
            FirstNamePrompt.Anchor = AnchorStyles.Right;
            FirstNamePrompt.Location = new Point(399, 54);
            FirstNamePrompt.Name = "FirstNamePrompt";
            FirstNamePrompt.Size = new Size(216, 23);
            FirstNamePrompt.TabIndex = 16;
            // 
            // DeletedUsersPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 450);
            Controls.Add(UpdateAndBringButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AddressPrompt);
            Controls.Add(EmailPrompt);
            Controls.Add(GsmPrompt);
            Controls.Add(LastNamePrompt);
            Controls.Add(FirstNamePrompt);
            Controls.Add(DeletePermenantlyButton);
            Controls.Add(label1);
            Controls.Add(UsersSearchBar);
            Controls.Add(DeletedUsersList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeletedUsersPanel";
            Text = "Silinen Kullanıcılar";
            Load += DeletedUsersPanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox DeletedUsersList;
        private TextBox UsersSearchBar;
        private Label label1;
        private Button DeletePermenantlyButton;
        private Button UpdateAndBringButton;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RichTextBox AddressPrompt;
        private TextBox EmailPrompt;
        private TextBox GsmPrompt;
        private TextBox LastNamePrompt;
        private TextBox FirstNamePrompt;
    }
}