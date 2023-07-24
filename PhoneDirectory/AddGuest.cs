using PhoneDirectory.Scripts;

namespace PhoneDirectory
{
    public partial class AddGuest : Form
    {
        private User user = new User();
        private List<User> users = new List<User>();

        private Guest guest = new Guest();

        private UsefulUtilities util = new UsefulUtilities();


        public AddGuest()
        {
            InitializeComponent();
        }

        private void AddGuest_Load(object sender, EventArgs e)
        {
            users = util.PrintUsersList("", UsersListBox, users, true);
        }

        private void CreateGuestButton_Click(object sender, EventArgs e)
        {
            guest.Name = NamePrompt.Text;
            guest.Surname = SurnamePrompt.Text;
            guest.CardId = Convert.ToInt32(CardIdPrompt.Text);
            guest.CompanyName = CompanyNamePrompt.Text;



            if (guest.CreateGuest())
            {
                MessageBox.Show("Misafir Başarıyla Oluşturuldu.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Misafir Oluşturulamadı.");
            }
        }

        private void UsersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = UsersListBox.SelectedIndex;

            if (selectedIndex < 0)
            {
                return;
            }

            guest.Visiting = users[selectedIndex];


        }

        private void UserSearchBar_TextChanged(object sender, EventArgs e)
        {
            string searchWord = util.ConvertInputToAscii(UserSearchBar.Text);
            users = util.PrintUsersList(searchWord, UsersListBox, users, true);

        }
    }
}
