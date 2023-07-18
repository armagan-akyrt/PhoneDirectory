﻿using PhoneDirectory.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneDirectory
{
    public partial class AddContact : Form
    {
        public string username;
        private Connection connection = new Connection();
        public AddContact(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private string ConvertInputToAscii(string input)
        {
            // contains lowercase turkish characters
            var charMap = new Dictionary<char, char>()
            {
                {'ç', 'c'},
                {'ğ', 'g'},
                {'ı', 'i'},
                {'ö', 'o'},
                {'ş', 's'},
                {'ü', 'u'}
            };

            foreach (KeyValuePair<char, char> entry in charMap)
            {
                input = input.Replace(entry.Key, entry.Value);
            }

            return input;
        }

        private void AddContact_Load(object sender, EventArgs e)
        {
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            string contactUsername = (NamePrompt.Text).ToLower().Replace(" ", "") + (SurnamePrompt.Text).ToLower().Replace(" ", "");
            contactUsername = ConvertInputToAscii(contactUsername);
            GsmPrompt.Text = GsmPrompt.Text.Replace(" ", "");

            string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            string gsmPattern = @"^(\+90|0)?(5\d{2})(\d{7})$";
            Regex rgx = new Regex(emailPattern);
            bool isEmailValid = rgx.IsMatch(EmailPrompt.Text);

            rgx = new Regex(gsmPattern);
            bool isGsmValid = rgx.IsMatch(GsmPrompt.Text);

            if (!isEmailValid)
            {
                MessageBox.Show("E-posta geçerli değil!");
                return;
            }
            if (!isGsmValid)
            {
                MessageBox.Show("GSM numarası geçerli değil!");
                return;
            }

            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("CreateContact", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@name", NamePrompt.Text);
                command.Parameters.AddWithValue("@surname", SurnamePrompt.Text);
                command.Parameters.AddWithValue("@gsmNum", GsmPrompt.Text);
                command.Parameters.AddWithValue("@email", EmailPrompt.Text);
                command.Parameters.AddWithValue("@address", AddressPrompt.Text);
                command.Parameters.AddWithValue("@userUserName", username);
                command.Parameters.AddWithValue("@contactUsername", contactUsername);

                command.ExecuteNonQuery();

            }
            catch   (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
