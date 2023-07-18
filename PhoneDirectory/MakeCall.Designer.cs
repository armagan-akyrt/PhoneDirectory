namespace PhoneDirectory
{
    partial class MakeCall
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
            btnCall = new Button();
            SuspendLayout();
            // 
            // btnCall
            // 
            btnCall.Location = new Point(366, 197);
            btnCall.Name = "btnCall";
            btnCall.Size = new Size(75, 23);
            btnCall.TabIndex = 0;
            btnCall.Text = "Ara";
            btnCall.UseVisualStyleBackColor = true;
            btnCall.Click += btnCall_Click;
            // 
            // MakeCall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCall);
            Name = "MakeCall";
            Text = "MakeCall";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCall;
    }
}