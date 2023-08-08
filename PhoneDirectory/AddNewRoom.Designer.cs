namespace PhoneDirectory
{
    partial class AddNewRoom
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
            groupBox1 = new GroupBox();
            btnBringContacts = new Button();
            DeleteUserButton = new Button();
            UsersSearchBar = new TextBox();
            UsersList = new ListBox();
            groupBox4 = new GroupBox();
            label11 = new Label();
            UserRoleBox = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            UserAddressPrompt = new RichTextBox();
            UserEmailPrompt = new TextBox();
            UserGsmPrompt = new TextBox();
            UserLastNamePrompt = new TextBox();
            UserFirstNamePropmt = new TextBox();
            AddRoomButton = new Button();
            label1 = new Label();
            RoomCapacityPrompt = new TextBox();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(btnBringContacts);
            groupBox1.Controls.Add(DeleteUserButton);
            groupBox1.Controls.Add(UsersSearchBar);
            groupBox1.Controls.Add(UsersList);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 611);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Oda Sorumlusu Ara:";
            // 
            // btnBringContacts
            // 
            btnBringContacts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBringContacts.Location = new Point(286, 1078);
            btnBringContacts.Name = "btnBringContacts";
            btnBringContacts.Size = new Size(75, 23);
            btnBringContacts.TabIndex = 4;
            btnBringContacts.Text = "Getir";
            btnBringContacts.UseVisualStyleBackColor = true;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteUserButton.Location = new Point(25, 1078);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(75, 23);
            DeleteUserButton.TabIndex = 9;
            DeleteUserButton.Text = "Sil";
            DeleteUserButton.UseVisualStyleBackColor = true;
            // 
            // UsersSearchBar
            // 
            UsersSearchBar.Location = new Point(25, 18);
            UsersSearchBar.Name = "UsersSearchBar";
            UsersSearchBar.Size = new Size(336, 23);
            UsersSearchBar.TabIndex = 5;
            UsersSearchBar.TextChanged += UsersSearchBar_TextChanged;
            // 
            // UsersList
            // 
            UsersList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            UsersList.FormattingEnabled = true;
            UsersList.ItemHeight = 15;
            UsersList.Location = new Point(25, 47);
            UsersList.Name = "UsersList";
            UsersList.Size = new Size(336, 544);
            UsersList.TabIndex = 0;
            UsersList.SelectedIndexChanged += UsersList_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(UserRoleBox);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(UserAddressPrompt);
            groupBox4.Controls.Add(UserEmailPrompt);
            groupBox4.Controls.Add(UserGsmPrompt);
            groupBox4.Controls.Add(UserLastNamePrompt);
            groupBox4.Controls.Add(UserFirstNamePropmt);
            groupBox4.Location = new Point(392, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(338, 389);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Oda Sorumlusu Bilgileri:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 165);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 22;
            label11.Text = "Rol:";
            // 
            // UserRoleBox
            // 
            UserRoleBox.FormattingEnabled = true;
            UserRoleBox.Items.AddRange(new object[] { "ADMIN", "USER" });
            UserRoleBox.Location = new Point(102, 162);
            UserRoleBox.Name = "UserRoleBox";
            UserRoleBox.Size = new Size(220, 23);
            UserRoleBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 239);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 21;
            label6.Text = "Adres:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 202);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 20;
            label7.Text = "E-posta:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 128);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 19;
            label8.Text = "Tel. No:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 91);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 18;
            label9.Text = "Soyad:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 59);
            label10.Name = "label10";
            label10.Size = new Size(25, 15);
            label10.TabIndex = 17;
            label10.Text = "Ad:";
            // 
            // UserAddressPrompt
            // 
            UserAddressPrompt.Location = new Point(102, 239);
            UserAddressPrompt.Name = "UserAddressPrompt";
            UserAddressPrompt.Size = new Size(220, 109);
            UserAddressPrompt.TabIndex = 15;
            UserAddressPrompt.Text = "";
            // 
            // UserEmailPrompt
            // 
            UserEmailPrompt.Location = new Point(102, 199);
            UserEmailPrompt.Name = "UserEmailPrompt";
            UserEmailPrompt.Size = new Size(220, 23);
            UserEmailPrompt.TabIndex = 14;
            // 
            // UserGsmPrompt
            // 
            UserGsmPrompt.Location = new Point(102, 125);
            UserGsmPrompt.Name = "UserGsmPrompt";
            UserGsmPrompt.Size = new Size(220, 23);
            UserGsmPrompt.TabIndex = 13;
            // 
            // UserLastNamePrompt
            // 
            UserLastNamePrompt.Location = new Point(102, 88);
            UserLastNamePrompt.Name = "UserLastNamePrompt";
            UserLastNamePrompt.Size = new Size(220, 23);
            UserLastNamePrompt.TabIndex = 12;
            // 
            // UserFirstNamePropmt
            // 
            UserFirstNamePropmt.Location = new Point(102, 51);
            UserFirstNamePropmt.Name = "UserFirstNamePropmt";
            UserFirstNamePropmt.Size = new Size(220, 23);
            UserFirstNamePropmt.TabIndex = 11;
            // 
            // AddRoomButton
            // 
            AddRoomButton.Location = new Point(639, 478);
            AddRoomButton.Name = "AddRoomButton";
            AddRoomButton.Size = new Size(75, 23);
            AddRoomButton.TabIndex = 16;
            AddRoomButton.Text = "Ekle";
            AddRoomButton.UseVisualStyleBackColor = true;
            AddRoomButton.Click += AddRoomButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(394, 425);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 16;
            label1.Text = "Oda Kapasitesi:";
            // 
            // RoomCapacityPrompt
            // 
            RoomCapacityPrompt.Location = new Point(494, 422);
            RoomCapacityPrompt.Name = "RoomCapacityPrompt";
            RoomCapacityPrompt.Size = new Size(220, 23);
            RoomCapacityPrompt.TabIndex = 17;
            // 
            // AddNewRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 682);
            Controls.Add(RoomCapacityPrompt);
            Controls.Add(label1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(AddRoomButton);
            Name = "AddNewRoom";
            Text = "AddNewRoom";
            Load += AddNewRoom_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnBringContacts;
        private Button DeleteUserButton;
        private TextBox UsersSearchBar;
        private ListBox UsersList;
        private GroupBox groupBox4;
        private Label label11;
        private ComboBox UserRoleBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button AddRoomButton;
        private RichTextBox UserAddressPrompt;
        private TextBox UserEmailPrompt;
        private TextBox UserGsmPrompt;
        private TextBox UserLastNamePrompt;
        private TextBox UserFirstNamePropmt;
        private Label label1;
        private TextBox RoomCapacityPrompt;
    }
}