namespace PhoneDirectory
{
    partial class PreviousMeetings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviousMeetings));
            groupBox1 = new GroupBox();
            PreviousMeetingsList = new ListBox();
            PreviousMeetingsSearchBar = new TextBox();
            FullNamePrompt = new TextBox();
            StartDateTimePicker = new DateTimePicker();
            EndDateTimePicker = new DateTimePicker();
            label1 = new Label();
            NotesBox = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DeleteButton = new Button();
            IntervalCalendar = new MonthCalendar();
            UpdateIntervalButton = new Button();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PreviousMeetingsList);
            groupBox1.Controls.Add(PreviousMeetingsSearchBar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 393);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Geçmiş Toplantılar:";
            // 
            // PreviousMeetingsList
            // 
            PreviousMeetingsList.FormattingEnabled = true;
            PreviousMeetingsList.ItemHeight = 15;
            PreviousMeetingsList.Location = new Point(6, 51);
            PreviousMeetingsList.Name = "PreviousMeetingsList";
            PreviousMeetingsList.Size = new Size(235, 334);
            PreviousMeetingsList.TabIndex = 1;
            PreviousMeetingsList.SelectedIndexChanged += PreviousMeetingsList_SelectedIndexChanged;
            // 
            // PreviousMeetingsSearchBar
            // 
            PreviousMeetingsSearchBar.Location = new Point(6, 22);
            PreviousMeetingsSearchBar.Name = "PreviousMeetingsSearchBar";
            PreviousMeetingsSearchBar.Size = new Size(235, 23);
            PreviousMeetingsSearchBar.TabIndex = 1;
            PreviousMeetingsSearchBar.TextChanged += PreviousMeetingsSearchBar_TextChanged;
            // 
            // FullNamePrompt
            // 
            FullNamePrompt.Location = new Point(283, 60);
            FullNamePrompt.Name = "FullNamePrompt";
            FullNamePrompt.Size = new Size(200, 23);
            FullNamePrompt.TabIndex = 1;
            // 
            // StartDateTimePicker
            // 
            StartDateTimePicker.CustomFormat = "dd/MM/yy - HH.mm";
            StartDateTimePicker.Format = DateTimePickerFormat.Custom;
            StartDateTimePicker.Location = new Point(283, 131);
            StartDateTimePicker.Name = "StartDateTimePicker";
            StartDateTimePicker.Size = new Size(200, 23);
            StartDateTimePicker.TabIndex = 2;
            // 
            // EndDateTimePicker
            // 
            EndDateTimePicker.CustomFormat = "dd/MM/yy - HH.mm";
            EndDateTimePicker.Format = DateTimePickerFormat.Custom;
            EndDateTimePicker.Location = new Point(283, 202);
            EndDateTimePicker.Name = "EndDateTimePicker";
            EndDateTimePicker.Size = new Size(200, 23);
            EndDateTimePicker.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 42);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Ad Soyad:";
            // 
            // NotesBox
            // 
            NotesBox.Location = new Point(283, 273);
            NotesBox.Name = "NotesBox";
            NotesBox.Size = new Size(200, 96);
            NotesBox.TabIndex = 5;
            NotesBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 113);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 6;
            label2.Text = "Başlangıç Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 184);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 7;
            label3.Text = "Bitiş Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 255);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 8;
            label4.Text = "Notlar";
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(408, 374);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Sil";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // IntervalCalendar
            // 
            IntervalCalendar.CalendarDimensions = new Size(1, 2);
            IntervalCalendar.Location = new Point(503, 60);
            IntervalCalendar.Name = "IntervalCalendar";
            IntervalCalendar.TabIndex = 10;
            // 
            // UpdateIntervalButton
            // 
            UpdateIntervalButton.Location = new Point(591, 374);
            UpdateIntervalButton.Name = "UpdateIntervalButton";
            UpdateIntervalButton.Size = new Size(139, 23);
            UpdateIntervalButton.TabIndex = 11;
            UpdateIntervalButton.Text = "Tarihleri Güncelle";
            UpdateIntervalButton.UseVisualStyleBackColor = true;
            UpdateIntervalButton.Click += UpdateIntervalButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(503, 42);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 12;
            label5.Text = "Tarih Aralığı:";
            // 
            // PreviousMeetings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 415);
            Controls.Add(label5);
            Controls.Add(UpdateIntervalButton);
            Controls.Add(IntervalCalendar);
            Controls.Add(DeleteButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NotesBox);
            Controls.Add(label1);
            Controls.Add(EndDateTimePicker);
            Controls.Add(StartDateTimePicker);
            Controls.Add(FullNamePrompt);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PreviousMeetings";
            Text = "Geçmiş Toplantılar";
            Load += PreviousMeetings_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox PreviousMeetingsSearchBar;
        private ListBox PreviousMeetingsList;
        private TextBox FullNamePrompt;
        private DateTimePicker StartDateTimePicker;
        private DateTimePicker EndDateTimePicker;
        private Label label1;
        private RichTextBox NotesBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button DeleteButton;
        private MonthCalendar IntervalCalendar;
        private Button UpdateIntervalButton;
        private Label label5;
    }
}