using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhoneDirectory.Scripts
{
    internal class UsefulUtilities
    {
        /// <summary>
        /// prints contacts list to listbox
        /// </summary>
        /// <param name="search"></param>
        /// <param name="listBox"></param>
        /// <param name="contacts"></param>
        /// <param name="username"></param>
        public List<Contact> PrintContactsList(string search, ListBox listBox, List<Contact> contacts, string username, bool activeState)
        {
            Contact contact = new Contact();
            contacts.Clear();
            contacts = contact.RetrieveContact(search, username, activeState);
            listBox.Items.Clear();
            foreach (Contact res in contacts)
            {
                string tagToWrite = "FIRST LAST".Replace("FIRST", res._name).Replace("LAST", res._surname);
                listBox.Items.Add(tagToWrite);
            }

            return contacts;
        }

        /// <summary>
        /// Prints users list to listbox
        /// </summary>
        /// <param name="search"></param>
        /// <param name="listBox"></param>
        /// <param name="users"></param>
        public List<User> PrintUsersList(string search, ListBox listBox, List<User> users, bool activeState)
        {
            User user = new User();
            users = user.RetrieveUsersList(search, activeState);
            listBox.Items.Clear();

            foreach (User res in users)
            {
                string tagToWrite = "FIRST LAST".Replace("FIRST", res._name).Replace("LAST", res._surname);
                listBox.Items.Add(tagToWrite);
            }

            return users;
        }

        /// <summary>
        /// converts turkish string into ascii string
        /// </summary>
        /// <param name="input"> input string of any size.</param>
        /// <returns>converted string</returns>
        public string ConvertInputToAscii(string input)
        {
            input = input.ToLower().Replace(" ", "");

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


    }
}
