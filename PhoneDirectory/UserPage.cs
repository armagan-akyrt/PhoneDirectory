using PhoneDirectory.Scripts;
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
    public partial class UserPage : Form
    {
        private List<Contact> contacts = new List<Contact>();

        public UserPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            string input = txtSearchBar.Text.ToLower();
            contacts = contact.RetrieveContact(txtSearchBar.Text);
            lbContacts.Items.Clear();
            foreach (Contact res in contacts)
            {
                string tagToWrite = "USERNAME, FIRST LAST".Replace("USERNAME", res._username).Replace("FIRST", res._name).Replace("LAST", res._surname);
                lbContacts.Items.Add(tagToWrite);
            }
        }

        
    }
}
