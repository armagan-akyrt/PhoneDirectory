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

        }

        private void RegeneratePassword_Click(object sender, EventArgs e)
        {
            PasswordPrompt.Text = user.GenerateRandomPassword();
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            user._name = FirstNamePrompt.Text;
            user._surname = LastNamePrompt.Text;
            user._phoneNumber = GsmPrompt.Text;
            user._email = EmailPrompt.Text;
            user._address = AddressPrompt.Text;
            user._role = RoleComboBox.SelectedText;
            user._password = PasswordPrompt.Text;
            user._username = " ";

            user.CreateUser();
        }
    }
}
