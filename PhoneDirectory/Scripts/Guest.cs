using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Scripts
{
    public class Guest
    {
        private string _name;
        private string _surname;
        private string _username;


        private int _id;
        private int _cardId;
        private User _visiting = new User();

        private DateTime _cardAcquisitionDate;
        private DateTime _cardSubmitDate;

        private UsefulUtilities util = new UsefulUtilities();
        private Connection connection = new Connection();

        #region Getters and Setters
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public int CardId
        {
            get { return _cardId; }
            set { _cardId = value; }
        }
        public DateTime CardAcquisitionDate
        {
            get { return _cardAcquisitionDate; }
            set { _cardAcquisitionDate = value; }
        }

        public User Visiting
        {
            get { return _visiting; }
            set { _visiting = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public DateTime CardSubmitDate
        {
            get { return _cardSubmitDate; }
            set { _cardSubmitDate = value; }
        }
        #endregion

        public Guest()
        {
            _name = "";
            _surname = "";
            _cardId = 0;
            _cardAcquisitionDate = DateTime.Now;
        }

        /// <summary>
        /// Creates a guest in the database
        /// </summary>
        /// <returns>true on success</returns>
        public bool CreateGuest()
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("AddGuest", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@firstName", this.Name);
                command.Parameters.AddWithValue("@lastName", this.Surname);
                command.Parameters.AddWithValue("@cardId", this.CardId);
                command.Parameters.AddWithValue("@userId", this.Visiting.Id);

                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@id";
                outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                outputParameter.Direction = System.Data.ParameterDirection.Output;
                command.Parameters.Add(outputParameter);

                command.ExecuteNonQuery();

                this._id = Convert.ToInt32(outputParameter.Value);

            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        /// <summary>
        /// Gets the list of all guests
        /// </summary>
        /// <param name="searchWord"> part of the username to search</param>
        /// <returns>list of guests with username containing a part of searchword</returns>
        public List<Guest> RetrieveAllGuest(string searchWord)
        {
            SqlConnection conn = connection.GetConnection();
            List<Guest> guests = new List<Guest>();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("RetrieveGuests", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                
                command.Parameters.AddWithValue("@username", searchWord);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Guest guest = new Guest();
                    guest.Name = reader["firstName"]?.ToString() ?? string.Empty;
                    guest.Surname = reader["lastName"]?.ToString() ?? string.Empty;
                    guest.CardId = Convert.ToInt32(reader["cardId"]);
                    guest.CardAcquisitionDate = Convert.ToDateTime(reader["acquisitionTime"]);
                    guest.Id = Convert.ToInt32(reader["id"]);
                    guest.Username = reader["username"]?.ToString() ?? string.Empty;
                    guest.CardSubmitDate = Convert.ToDateTime(reader["cardSubmitDate"]);

                    User user = new User();
                    user.Name = reader["userFirstName"]?.ToString() ?? string.Empty;
                    user.Surname = reader["userLastName"]?.ToString() ?? string.Empty;
                    user.Id = Convert.ToInt32(reader["userId"]);
                    user.Username = reader["userUsername"]?.ToString() ?? string.Empty;
                    user.PhoneNumber = reader["gsmNumber"]?.ToString() ?? string.Empty;
                    user.Mail = reader["email"]?.ToString() ?? string.Empty;
                    user.Role = reader["role"]?.ToString() ?? string.Empty;

                    guest.Visiting = user;
                    guests.Add(guest);
                }

            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                conn.Close();
            }

            return guests;
        }

        /// <summary>
        /// Gets the list of guests that are currently inside the building
        /// </summary>
        /// <param name="searchWord">part of the username to search</param>
        /// <returns>list of guests with username containing a part of searchword</returns>
        public List<Guest> RetrieveGuestsInside(string searchWord)
        {
            SqlConnection conn = connection.GetConnection();
            List<Guest> guests = new List<Guest>();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("RetrieveGuestsInside", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@username", searchWord);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Guest guest = new Guest();
                    guest.Name = reader["firstName"]?.ToString() ?? string.Empty;
                    guest.Surname = reader["lastName"]?.ToString() ?? string.Empty;
                    guest.CardId = Convert.ToInt32(reader["cardId"]);
                    guest.CardAcquisitionDate = Convert.ToDateTime(reader["acquisitionTime"]);
                    guest.Id = Convert.ToInt32(reader["id"]);
                    guest.Username = reader["username"]?.ToString() ?? string.Empty;

                    User user = new User();
                    user.Name = reader["userFirstName"]?.ToString() ?? string.Empty;
                    user.Surname = reader["userLastName"]?.ToString() ?? string.Empty;
                    user.Id = Convert.ToInt32(reader["userId"]);
                    user.Username = reader["userUsername"]?.ToString() ?? string.Empty;
                    user.PhoneNumber = reader["gsmNumber"]?.ToString() ?? string.Empty;
                    user.Mail = reader["email"]?.ToString() ?? string.Empty;
                    user.Role = reader["role"]?.ToString() ?? string.Empty;


                    guest.Visiting = user;
                    guests.Add(guest);
                }
            }

            
            catch (Exception)
            {

                return null;
            }
            finally
            {
                conn.Close();
            }

            return guests;
        }

        /// <summary>
        /// Writes the card obtained date to the database.
        /// </summary>
        /// <returns>true on success</returns>
        public bool ObtainCard()
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("ObtainCard", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@cardId", this.CardId);
                command.Parameters.AddWithValue("@id", this.Id);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        /// <summary>
        /// Delete guest from database
        /// </summary>
        /// <returns>true on success</returns>
        public bool DeleteGuest()
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("DeleteGuest", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id", this.Id);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                
                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;

        }

    }
}
