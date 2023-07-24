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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestsList));
            GuestsListBox = new ListBox();
            groupBox1 = new GroupBox();
            CompanyNameSearch = new TextBox();
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
            IntervalCalendar = new MonthCalendar();
            label7 = new Label();
            UpdateHistoryInterval = new Button();
            CompanyNameBox = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // GuestsListBox
            // 
            GuestsListBox.FormattingEnabled = true;
            GuestsListBox.ItemHeight = 15;
            GuestsListBox.Location = new Point(6, 86);
            GuestsListBox.Name = "GuestsListBox";
            GuestsListBox.Size = new Size(249, 334);
            GuestsListBox.TabIndex = 0;
            GuestsListBox.SelectedIndexChanged += GuestsListBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CompanyNameSearch);
            groupBox1.Controls.Add(GuestSearchBar);
            groupBox1.Controls.Add(GuestsListBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Misafirler:";
            // 
            // CompanyNameSearch
            // 
            CompanyNameSearch.Location = new Point(6, 51);
            CompanyNameSearch.Name = "CompanyNameSearch";
            CompanyNameSearch.Size = new Size(249, 23);
            CompanyNameSearch.TabIndex = 3;
            CompanyNameSearch.Text = "Firma adıyla ara";
            CompanyNameSearch.TextChanged += CompanyNameSearch_TextChanged;
            CompanyNameSearch.Enter += CompanyNameSearch_Enter;
            CompanyNameSearch.Leave += CompanyNameSearch_Leave;
            // 
            // GuestSearchBar
            // 
            GuestSearchBar.Location = new Point(6, 22);
            GuestSearchBar.Name = "GuestSearchBar";
            GuestSearchBar.Size = new Size(249, 23);
            GuestSearchBar.TabIndex = 2;
            GuestSearchBar.Text = "Kullanıcı adıyla ara";
            GuestSearchBar.TextChanged += GuestSearchBar_TextChanged;
            GuestSearchBar.Enter += GuestSearchBar_Enter;
            GuestSearchBar.Leave += GuestSearchBar_Leave;
            // 
            // FirstNamePrompt
            // 
            FirstNamePrompt.Location = new Point(281, 46);
            FirstNamePrompt.Name = "FirstNamePrompt";
            FirstNamePrompt.ReadOnly = true;
            FirstNamePrompt.Size = new Size(229, 23);
            FirstNamePrompt.TabIndex = 2;
            // 
            // LastNamePrompt
            // 
            LastNamePrompt.Location = new Point(281, 105);
            LastNamePrompt.Name = "LastNamePrompt";
            LastNamePrompt.ReadOnly = true;
            LastNamePrompt.Size = new Size(229, 23);
            LastNamePrompt.TabIndex = 3;
            // 
            // AcquireDateTimePicker
            // 
            AcquireDateTimePicker.CustomFormat = "dd/MM/yy - HH.mm";
            AcquireDateTimePicker.Format = DateTimePickerFormat.Custom;
            AcquireDateTimePicker.Location = new Point(281, 272);
            AcquireDateTimePicker.Name = "AcquireDateTimePicker";
            AcquireDateTimePicker.Size = new Size(229, 23);
            AcquireDateTimePicker.TabIndex = 4;
            // 
            // SubmitDateTimePicker
            // 
            SubmitDateTimePicker.CustomFormat = "dd/MM/yy - HH.mm";
            SubmitDateTimePicker.Format = DateTimePickerFormat.Custom;
            SubmitDateTimePicker.Location = new Point(281, 334);
            SubmitDateTimePicker.Name = "SubmitDateTimePicker";
            SubmitDateTimePicker.Size = new Size(229, 23);
            SubmitDateTimePicker.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 28);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 6;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 87);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 7;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 254);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 8;
            label3.Text = "Kart Verilme Tarih:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 316);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 9;
            label4.Text = "Kart Teslim Tarihi:";
            // 
            // GetCardButton
            // 
            GetCardButton.Location = new Point(400, 409);
            GetCardButton.Name = "GetCardButton";
            GetCardButton.Size = new Size(110, 23);
            GetCardButton.TabIndex = 10;
            GetCardButton.Text = "Teslim Alındı";
            GetCardButton.UseVisualStyleBackColor = true;
            GetCardButton.Click += GetCardButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(281, 409);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(78, 23);
            DeleteButton.TabIndex = 11;
            DeleteButton.Text = "Sil";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 199);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 12;
            label5.Text = "Ziyaret Edilen Kişi:";
            // 
            // VisitedGuestBox
            // 
            VisitedGuestBox.Location = new Point(283, 217);
            VisitedGuestBox.Name = "VisitedGuestBox";
            VisitedGuestBox.ReadOnly = true;
            VisitedGuestBox.Size = new Size(227, 23);
            VisitedGuestBox.TabIndex = 13;
            // 
            // IntervalCalendar
            // 
            IntervalCalendar.CalendarDimensions = new Size(1, 2);
            IntervalCalendar.Location = new Point(546, 68);
            IntervalCalendar.MaxSelectionCount = 60;
            IntervalCalendar.Name = "IntervalCalendar";
            IntervalCalendar.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(546, 44);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 17;
            label7.Text = "Başlangıç Tarihi:";
            // 
            // UpdateHistoryInterval
            // 
            UpdateHistoryInterval.Location = new Point(652, 409);
            UpdateHistoryInterval.Name = "UpdateHistoryInterval";
            UpdateHistoryInterval.Size = new Size(121, 23);
            UpdateHistoryInterval.TabIndex = 18;
            UpdateHistoryInterval.Text = "Tarihleri Güncelle";
            UpdateHistoryInterval.UseVisualStyleBackColor = true;
            UpdateHistoryInterval.Click += UpdateHistoryInterval_Click;
            // 
            // CompanyNameBox
            // 
            CompanyNameBox.Location = new Point(281, 164);
            CompanyNameBox.Name = "CompanyNameBox";
            CompanyNameBox.ReadOnly = true;
            CompanyNameBox.Size = new Size(229, 23);
            CompanyNameBox.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(281, 146);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 20;
            label6.Text = "Firma Adı:";
            // 
            // GuestsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(CompanyNameBox);
            Controls.Add(UpdateHistoryInterval);
            Controls.Add(label7);
            Controls.Add(IntervalCalendar);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private MonthCalendar IntervalCalendar;
        private Label label7;
        private Button UpdateHistoryInterval;
        private TextBox CompanyNameSearch;
        private TextBox CompanyNameBox;
        private Label label6;
    }
}