namespace PhoneDirectory
{
    partial class Conferences
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            AddRoomToolStripMenu = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { AddRoomToolStripMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1150, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // AddRoomToolStripMenu
            // 
            AddRoomToolStripMenu.Name = "AddRoomToolStripMenu";
            AddRoomToolStripMenu.Size = new Size(65, 20);
            AddRoomToolStripMenu.Text = "Oda Ekle";
            AddRoomToolStripMenu.Click += AddRoomToolStripMenu_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 6000;
            timer1.Tick += timer1_Tick;
            // 
            // Conferences
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 640);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Conferences";
            Text = "Konferanslar";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem AddRoomToolStripMenu;
        private System.Windows.Forms.Timer timer1;
    }
}