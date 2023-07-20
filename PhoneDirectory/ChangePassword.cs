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
        public ChangePassword(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void ChangePwdButton_Click(object sender, EventArgs e)
        {
            if (!user._password.Equals(OldPwdText.Text))
            {
                MessageBox.Show("Eski şifre yanlış!!");
                return;
            }

            if (NewPwdBox.Text.Equals(NewPwdAgain.Text))
            {
                user.ChangePassword(NewPwdBox.Text, OldPwdText.Text);
                MessageBox.Show("Şifre başarıyla değiştirildi!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor!");
            }
        }
    }
}
