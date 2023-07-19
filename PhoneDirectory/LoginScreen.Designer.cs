namespace PhoneDirectory
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            EmailPrompt = new TextBox();
            PasswordPrompt = new TextBox();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(133, 289);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Giriş";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 144);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Şifre:";
            // 
            // EmailPrompt
            // 
            EmailPrompt.Location = new Point(12, 75);
            EmailPrompt.Name = "EmailPrompt";
            EmailPrompt.Size = new Size(196, 23);
            EmailPrompt.TabIndex = 3;
            // 
            // PasswordPrompt
            // 
            PasswordPrompt.Location = new Point(12, 176);
            PasswordPrompt.Name = "PasswordPrompt";
            PasswordPrompt.PasswordChar = '*';
            PasswordPrompt.Size = new Size(196, 23);
            PasswordPrompt.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\MONSTER\\source\\repos\\PhoneDirectory\\PhoneDirectory\\Assets\\logo.png";
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(214, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(273, 202);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(45, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "İletişim";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 334);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(PasswordPrompt);
            Controls.Add(EmailPrompt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Name = "LoginScreen";
            Text = "Giriş";
            Load += LoginScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private Label label2;
        private TextBox EmailPrompt;
        private TextBox PasswordPrompt;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
    }
}