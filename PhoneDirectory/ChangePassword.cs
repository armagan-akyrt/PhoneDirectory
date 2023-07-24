using PhoneDirectory.Scripts;

namespace PhoneDirectory
{
    public partial class ChangePassword : Form
    {
        public string username;
        private string oldPwd;
        private User user = new User();

        private UsefulUtilities util = new UsefulUtilities();

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

            oldPwd = util.EncryptPassword(OldPwdText.Text);


            if (!user.Password.Equals(oldPwd))
            {
                MessageBox.Show("Eski şifre yanlış!!");
                return;
            }

            if (NewPwdBox.Text.Equals(NewPwdAgain.Text))
            {
                user.ChangePassword(NewPwdBox.Text, oldPwd);
                
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
