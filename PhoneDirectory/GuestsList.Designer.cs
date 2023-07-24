namespace PhoneDirectory
{
    partial class GuestsList
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
            GuestsListBox = new ListBox();
            groupBox1 = new GroupBox();
            GuestSearchBar = new TextBox();
            FirstNamePrompt = new TextBox();
            LastNamePrompt = new TextBox();
            AcquireDateTimePicker = new DateTimePicker();
            SubmitDateTimePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            GetCardButton = new Button();
            DeleteButton = new Button();
            label5 = new Label();
            VisitedGuestBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // GuestsListBox
            // 
            GuestsListBox.FormattingEnabled = true;
            GuestsListBox.ItemHeight = 15;
            GuestsListBox.Location = new Point(6, 56);
            GuestsListBox.Name = "GuestsListBox";
            GuestsListBox.Size = new Size(249, 364);
            GuestsListBox.TabIndex = 0;
            GuestsListBox.SelectedIndexChanged += GuestsListBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GuestSearchBar);
            groupBox1.Controls.Add(GuestsListBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Misafirler:";
            // 
            // GuestSearchBar
            // 
            GuestSearchBar.Location = new Point(6, 22);
            GuestSearchBar.Name = "GuestSearchBar";
            GuestSearchBar.Size = new Size(249, 23);
            GuestSearchBar.TabIndex = 2;
            // 
            // FirstNamePrompt
            // 
            FirstNamePrompt.Location = new Point(281, 68);
            FirstNamePrompt.Name = "FirstNamePrompt";
            FirstNamePrompt.ReadOnly = true;
            FirstNamePrompt.Size = new Size(229, 23);
            FirstNamePrompt.TabIndex = 2;
            // 
            // LastNamePrompt
            // 
            LastNamePrompt.Location = new Point(281, 127);
            LastNamePrompt.Name = "LastNamePrompt";
            LastNamePrompt.ReadOnly = true;
            LastNamePrompt.Size = new Size(229, 23);
            LastNamePrompt.TabIndex = 3;
            // 
            // AcquireDateTimePicker
            // 
            AcquireDateTimePicker.CustomFormat = "dd/MM/yy - HH.mm";
            AcquireDateTimePicker.Format = DateTimePickerFormat.Custom;
            AcquireDateTimePicker.Location = new Point(281, 257);
            AcquireDateTimePicker.Name = "AcquireDateTimePicker";
            AcquireDateTimePicker.Size = new Size(229, 23);
            AcquireDateTimePicker.TabIndex = 4;
            // 
            // SubmitDateTimePicker
            // 
            SubmitDateTimePicker.CustomFormat = "dd/MM/yy - HH.mm";
            SubmitDateTimePicker.Format = DateTimePickerFormat.Custom;
            SubmitDateTimePicker.Location = new Point(281, 319);
            SubmitDateTimePicker.Name = "SubmitDateTimePicker";
            SubmitDateTimePicker.Size = new Size(229, 23);
            SubmitDateTimePicker.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 50);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 6;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 109);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 7;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 239);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 8;
            label3.Text = "Kart Verilme Tarih:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 301);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 9;
            label4.Text = "Kart Teslim Tarihi:";
            // 
            // GetCardButton
            // 
            GetCardButton.Location = new Point(400, 366);
            GetCardButton.Name = "GetCardButton";
            GetCardButton.Size = new Size(110, 23);
            GetCardButton.TabIndex = 10;
            GetCardButton.Text = "Teslim Alındı";
            GetCardButton.UseVisualStyleBackColor = true;
            GetCardButton.Click += GetCardButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(281, 366);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(78, 23);
            DeleteButton.TabIndex = 11;
            DeleteButton.Text = "Sil";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 174);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 12;
            label5.Text = "Ziyaret Edilen Kişi:";
            // 
            // VisitedGuestBox
            // 
            VisitedGuestBox.Location = new Point(283, 192);
            VisitedGuestBox.Name = "VisitedGuestBox";
            VisitedGuestBox.ReadOnly = true;
            VisitedGuestBox.Size = new Size(227, 23);
            VisitedGuestBox.TabIndex = 13;
            // 
            // GuestsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VisitedGuestBox);
            Controls.Add(label5);
            Controls.Add(DeleteButton);
            Controls.Add(GetCardButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SubmitDateTimePicker);
            Controls.Add(AcquireDateTimePicker);
            Controls.Add(LastNamePrompt);
            Controls.Add(FirstNamePrompt);
            Controls.Add(groupBox1);
            Name = "GuestsList";
            Text = "GuestsList";
            Load += GuestsList_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox GuestsListBox;
        private GroupBox groupBox1;
        private TextBox GuestSearchBar;
        private TextBox FirstNamePrompt;
        private TextBox LastNamePrompt;
        private DateTimePicker AcquireDateTimePicker;
        private DateTimePicker SubmitDateTimePicker;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button GetCardButton;
        private Button DeleteButton;
        private Label label5;
        private TextBox VisitedGuestBox;
    }
}