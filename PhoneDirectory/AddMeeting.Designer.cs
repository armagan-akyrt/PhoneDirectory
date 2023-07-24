namespace PhoneDirectory
{
    partial class AddMeeting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMeeting));
            groupBox1 = new GroupBox();
            ContactSearchBar = new TextBox();
            ContactsListBox = new ListBox();
            StartDatePicker = new DateTimePicker();
            EndDatePicker = new DateTimePicker();
            NotesBox = new RichTextBox();
            AddMeetingButton = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ContactSearchBar);
            groupBox1.Controls.Add(ContactsListBox);
            groupBox1.Location = new Point(12, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bağlantılar:";
            // 
            // ContactSearchBar
            // 
            ContactSearchBar.Location = new Point(6, 21);
            ContactSearchBar.Name = "ContactSearchBar";
            ContactSearchBar.Size = new Size(255, 23);
            ContactSearchBar.TabIndex = 1;
            ContactSearchBar.TextChanged += ContactSearchBar_TextChanged;
            // 
            // ContactsListBox
            // 
            ContactsListBox.FormattingEnabled = true;
            ContactsListBox.ItemHeight = 15;
            ContactsListBox.Location = new Point(6, 50);
            ContactsListBox.Name = "ContactsListBox";
            ContactsListBox.Size = new Size(255, 364);
            ContactsListBox.TabIndex = 0;
            ContactsListBox.SelectedIndexChanged += ContactsListBox_SelectedIndexChanged;
            // 
            // StartDatePicker
            // 
            StartDatePicker.CustomFormat = "dd/MM/yy - hh.mm";
            StartDatePicker.Format = DateTimePickerFormat.Custom;
            StartDatePicker.Location = new Point(285, 122);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(219, 23);
            StartDatePicker.TabIndex = 2;
            StartDatePicker.ValueChanged += StartDatePicker_ValueChanged;
            // 
            // EndDatePicker
            // 
            EndDatePicker.CustomFormat = "dd/MM/yy - hh.mm";
            EndDatePicker.Format = DateTimePickerFormat.Custom;
            EndDatePicker.Location = new Point(285, 203);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(219, 23);
            EndDatePicker.TabIndex = 3;
            EndDatePicker.ValueChanged += EndDatePicker_ValueChanged;
            // 
            // NotesBox
            // 
            NotesBox.Location = new Point(285, 274);
            NotesBox.Name = "NotesBox";
            NotesBox.Size = new Size(219, 148);
            NotesBox.TabIndex = 4;
            NotesBox.Text = "";
            // 
            // AddMeetingButton
            // 
            AddMeetingButton.Location = new Point(429, 428);
            AddMeetingButton.Name = "AddMeetingButton";
            AddMeetingButton.Size = new Size(75, 23);
            AddMeetingButton.TabIndex = 5;
            AddMeetingButton.Text = "Oluştur";
            AddMeetingButton.UseVisualStyleBackColor = true;
            AddMeetingButton.Click += AddMeetingButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(285, 104);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 6;
            label1.Text = "Başlangıç Tarihi:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 185);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 7;
            label2.Text = "Bitiş Tarihi:";
            // 
            // AddMeeting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 463);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddMeetingButton);
            Controls.Add(NotesBox);
            Controls.Add(EndDatePicker);
            Controls.Add(StartDatePicker);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddMeeting";
            Text = "Toplantı Oluştur";
            Load += AddMeeting_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox ContactSearchBar;
        private ListBox ContactsListBox;
        private DateTimePicker StartDatePicker;
        private DateTimePicker EndDatePicker;
        private RichTextBox NotesBox;
        private Button AddMeetingButton;
        private Label label1;
        private Label label2;
    }
}