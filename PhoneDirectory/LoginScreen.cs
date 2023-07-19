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
            Connection connection = new Connection();
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("VerifyUnamePwd", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@email", EmailPrompt.Text);
                command.Parameters.AddWithValue("@password", PasswordPrompt.Text);


                SqlDataReader reader = command.ExecuteReader();

                string role = command.Parameters["@role"].Value.ToString();
                username = command.Parameters["@username"].Value.ToString();

                if (!string.IsNullOrEmpty(role))
                {
                    // if verified, open admin page.
                    MessageBox.Show("Giriş Başarılı.");

                    User user = new User();
                    while (reader.Read())
                    {
                        user._name = reader["firstName"].ToString();
                        user._surname = reader["lastName"].ToString();
                        user._phoneNumber = reader["gsmNumber"].ToString();
                        user._email = reader["email"].ToString();
                        user._address = reader["address"].ToString();
                        user._username = reader["username"].ToString();
                        user._role = reader["role"].ToString();
                        user._password = reader["password"].ToString();
                    }


                    this.Hide();

                    if (role == "USER")
                    {
                        // open user page
                        UserPage userPage = new UserPage(username, role);
                        userPage.Show();
                    }
                    else
                    {
                        // opens admin page
                        AdminPage adminPage = new AdminPage(username, role);
                        adminPage.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private bool VerifyPassword(string passwordInput, string passwordFromDB)
        {

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(passwordInput));
                string hashedPasswordInput = Convert.ToBase64String(hashBytes);

                return (hashedPasswordInput == passwordFromDB);
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
    }
}
