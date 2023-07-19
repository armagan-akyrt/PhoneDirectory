using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneDirectory.Scripts;

namespace PhoneDirectory
{
    public partial class ChangePassword : Form
    {
        public string username;
        private User user = new User();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void ChangePwdButton_Click(object sender, EventArgs e)
        {
            if (NewPwdBox.Text.Equals(NewPwdAgain.Text))
            {
                user.ChangePassword(username, NewPwdBox.Text);
                MessageBox.Show("Password changed successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Passwords do not match!");
            }
        }
    }
}
