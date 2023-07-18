using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneDirectory
{
    public partial class AdminPage : Form
    {
        public string username;
        public AdminPage(string username)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.username = username;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void txtSearchUsers_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchContacts_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage(username);
            userPage.Show();
            this.Hide();
        }
    }
}
