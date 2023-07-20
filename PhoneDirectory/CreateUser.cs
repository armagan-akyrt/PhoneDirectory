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
    public partial class CreateUser : Form
    {
        public string username;

        private User user = new User();

        public CreateUser(string username)
        {
            InitializeComponent();
            this.username = username;
        }


        private void CreateUser_Load(object sender, EventArgs e)
        {
            PasswordPrompt.Text = user.GenerateRandomPassword();
            


            if(username.Length == 0)
            {
                label5.Hide();
                RoleComboBox.Hide();
            }
            else
            {
                label5.Show();
                RoleComboBox.Show();
            }
        }

        private void RegeneratePassword_Click(object sender, EventArgs e)
        {
            PasswordPrompt.Text = user.GenerateRandomPassword();
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            user.Name = FirstNamePrompt.Text;
            user.Surname = LastNamePrompt.Text;
            user.PhoneNumber = GsmPrompt.Text;
            user.Mail = EmailPrompt.Text;
            user.Address = AddressPrompt.Text;
            user.Role = (username.Length > 0) ? RoleComboBox.Text : "USER";
            user.Password = PasswordPrompt.Text;
            user.Username = " ";

            if(user.CreateUser())
            {
                MessageBox.Show("Kullanıcı başarıyla oluşturuldu.");
                this.Close();
                return;
            }

            MessageBox.Show("Kullanıcı oluşturulamadı!");


        }
    }
}
