namespace PhoneDirectory
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            OldPwdText = new TextBox();
            NewPwdBox = new TextBox();
            NewPwdAgain = new TextBox();
            ChangePwdButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Eski Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Yeni Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 170);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Yeni Şifre(Tekrar):";
            // 
            // OldPwdText
            // 
            OldPwdText.Location = new Point(12, 74);
            OldPwdText.Name = "OldPwdText";
            OldPwdText.PasswordChar = '*';
            OldPwdText.Size = new Size(198, 23);
            OldPwdText.TabIndex = 3;
            // 
            // NewPwdBox
            // 
            NewPwdBox.Location = new Point(12, 127);
            NewPwdBox.Name = "NewPwdBox";
            NewPwdBox.PasswordChar = '*';
            NewPwdBox.Size = new Size(198, 23);
            NewPwdBox.TabIndex = 4;
            // 
            // NewPwdAgain
            // 
            NewPwdAgain.Location = new Point(12, 188);
            NewPwdAgain.Name = "NewPwdAgain";
            NewPwdAgain.PasswordChar = '*';
            NewPwdAgain.Size = new Size(198, 23);
            NewPwdAgain.TabIndex = 5;
            // 
            // ChangePwdButton
            // 
            ChangePwdButton.Location = new Point(135, 231);
            ChangePwdButton.Name = "ChangePwdButton";
            ChangePwdButton.Size = new Size(75, 23);
            ChangePwdButton.TabIndex = 6;
            ChangePwdButton.Text = "Değiştir";
            ChangePwdButton.UseVisualStyleBackColor = true;
            ChangePwdButton.Click += ChangePwdButton_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 272);
            Controls.Add(ChangePwdButton);
            Controls.Add(NewPwdAgain);
            Controls.Add(NewPwdBox);
            Controls.Add(OldPwdText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChangePassword";
            Text = "Şifre Değiştirme";
            Load += ChangePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox OldPwdText;
        private TextBox NewPwdBox;
        private TextBox NewPwdAgain;
        private Button ChangePwdButton;
    }
}