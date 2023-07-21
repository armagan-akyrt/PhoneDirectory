namespace PhoneDirectory
{
    partial class AddGuest
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
            CreateGuestButton = new Button();
            SurnamePrompt = new TextBox();
            label3 = new Label();
            NamePrompt = new TextBox();
            label2 = new Label();
            CardIdPrompt = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            UserSearchBar = new TextBox();
            UsersListBox = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CreateGuestButton
            // 
            CreateGuestButton.Location = new Point(444, 221);
            CreateGuestButton.Name = "CreateGuestButton";
            CreateGuestButton.Size = new Size(75, 23);
            CreateGuestButton.TabIndex = 29;
            CreateGuestButton.Text = "Oluştur";
            CreateGuestButton.UseVisualStyleBackColor = true;
            CreateGuestButton.Click += CreateGuestButton_Click;
            // 
            // SurnamePrompt
            // 
            SurnamePrompt.Location = new Point(280, 99);
            SurnamePrompt.Name = "SurnamePrompt";
            SurnamePrompt.Size = new Size(239, 23);
            SurnamePrompt.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 81);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 21;
            label3.Text = "Soyad";
            // 
            // NamePrompt
            // 
            NamePrompt.Location = new Point(280, 42);
            NamePrompt.Name = "NamePrompt";
            NamePrompt.Size = new Size(239, 23);
            NamePrompt.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 24);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 19;
            label2.Text = "Ad";
            // 
            // CardIdPrompt
            // 
            CardIdPrompt.Location = new Point(280, 159);
            CardIdPrompt.Name = "CardIdPrompt";
            CardIdPrompt.Size = new Size(239, 23);
            CardIdPrompt.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 141);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 31;
            label1.Text = "Verilecek Kart";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(UserSearchBar);
            groupBox1.Controls.Add(UsersListBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 392);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Listesi:";
            // 
            // UserSearchBar
            // 
            UserSearchBar.Location = new Point(6, 23);
            UserSearchBar.Name = "UserSearchBar";
            UserSearchBar.Size = new Size(250, 23);
            UserSearchBar.TabIndex = 1;
            UserSearchBar.TextChanged += UserSearchBar_TextChanged;
            // 
            // UsersListBox
            // 
            UsersListBox.FormattingEnabled = true;
            UsersListBox.ItemHeight = 15;
            UsersListBox.Location = new Point(6, 52);
            UsersListBox.Name = "UsersListBox";
            UsersListBox.Size = new Size(250, 334);
            UsersListBox.TabIndex = 0;
            UsersListBox.SelectedIndexChanged += UsersListBox_SelectedIndexChanged;
            // 
            // AddGuest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 416);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(CardIdPrompt);
            Controls.Add(CreateGuestButton);
            Controls.Add(SurnamePrompt);
            Controls.Add(label3);
            Controls.Add(NamePrompt);
            Controls.Add(label2);
            Name = "AddGuest";
            Text = "AddGuest";
            Load += AddGuest_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CreateGuestButton;
        private TextBox SurnamePrompt;
        private Label label3;
        private TextBox NamePrompt;
        private Label label2;
        private TextBox CardIdPrompt;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox UserSearchBar;
        private ListBox UsersListBox;
    }
}