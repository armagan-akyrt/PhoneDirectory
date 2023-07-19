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

                SqlParameter roleParam = new SqlParameter("@role", SqlDbType.VarChar, 50);
                roleParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(roleParam);

                SqlParameter usernameParam = new SqlParameter("@username", SqlDbType.VarChar, 50);
                usernameParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(usernameParam);

                command.ExecuteNonQuery();

                string role = command.Parameters["@role"].Value.ToString();
                username = command.Parameters["@username"].Value.ToString();

                if (!string.IsNullOrEmpty(role))
                {
                    // if verified, open admin page.
                    MessageBox.Show("Giriş Başarılı.");

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
    }
}
