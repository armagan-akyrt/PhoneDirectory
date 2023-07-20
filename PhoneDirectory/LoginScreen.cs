using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using PhoneDirectory.Scripts;

namespace PhoneDirectory
{
    public partial class LoginScreen : Form
    {
        private string username;
        private User user = new User();
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// validates username and password and opens next page accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string pwdEncrypted = new UsefulUtilities().EncryptPassword(PasswordPrompt.Text);

            user = user.LoginVerify(EmailPrompt.Text, PasswordPrompt.Text);


            string role = user.Role;
            username = user.Username;

            if (!string.IsNullOrEmpty(role))
            {
                // if verified, open admin page.
                MessageBox.Show("Giriş Başarılı.");


                this.Hide();

                if (role == "USER")
                {
                    // open user page
                    UserPage userPage = new UserPage(user);
                    userPage.Show();
                }
                else
                {
                    // opens admin page
                    AdminPage adminPage = new AdminPage(user);
                    adminPage.Show();
                }

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://ilgisoft.com/info";
            System.Diagnostics.Process.Start(url);
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            Form CreateUser = new CreateUser("");
            CreateUser.ShowDialog();
        }

        private void LoginScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
