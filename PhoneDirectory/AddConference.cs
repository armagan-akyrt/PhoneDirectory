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
    public partial class AddConference : Form
    {
        private User currentUser;
        private List<User> users = new List<User>();
        private UsefulUtilities util = new UsefulUtilities();
        private List<int> participantIds;

        private User selectedUser = new User();

        public AddConference(User user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        private void AddConference_Load(object sender, EventArgs e)
        {
            users = util.PrintUsersList("", UsersListBox, users, true);

        }

        private void UsersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
