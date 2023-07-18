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
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
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
                SqlCommand command = new SqlCommand("prVerifyUnamePwd", conn);
                command.CommandType = CommandType.StoredProcedure;
                
                command.Parameters.AddWithValue("@username", txtUsername.Text);
                command.Parameters.AddWithValue("@password", txtPwd.Text);

                SqlParameter roleParam = new SqlParameter("@role", SqlDbType.VarChar, 50);
                roleParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(roleParam);

                command.ExecuteNonQuery();

                string role = command.Parameters["@role"].Value.ToString();

                if (!string.IsNullOrEmpty(role)) 
                { 
                    // if verified, open admin page.
                    MessageBox.Show("Login successful.");

                    this.Hide();

                    if (role == "USER")
                    {
                        // open user page
                        UserPage userPage = new UserPage();
                        userPage.Show();
                    }
                    else
                    {
                        // opens admin page
                        AdminPage adminPage = new AdminPage();
                        adminPage.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
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
