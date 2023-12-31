﻿using System;
using System.Data.SqlClient;

namespace PhoneDirectory.Scripts
{
    public class Meeting
    {

        private User _user = new User();
        private Contact _contact = new Contact();
        
        private int _meetingId;
        private string _meetingNotes;

        private DateTime _meetingStartDate;
        private DateTime _meetingEndDate;

        private Connection connection = new Connection();

        public Meeting()
        {

        }

        #region getters and setters
        public int MeetingId { get => _meetingId; set => _meetingId = value; }
        public string MeetingNotes { get => _meetingNotes; set => _meetingNotes = value; }
        public DateTime MeetingStartDate { get => _meetingStartDate; set => _meetingStartDate = value; }
        public DateTime MeetingEndDate { get => _meetingEndDate; set => _meetingEndDate = value; }
        public User User { get => _user; set => _user = value; }
        public Contact Contact { get => _contact; set => _contact = value; }
        #endregion

        /// <summary>
        /// Creates a meeting in the database
        /// </summary>
        /// <returns>true on success</returns>
        public bool CreateMeeting()
        {
            SqlConnection conn = connection.GetConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("AddMeeting", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@notes", this._meetingNotes);
                command.Parameters.AddWithValue("@startDate", this._meetingStartDate);
                command.Parameters.AddWithValue("@endDate", this._meetingEndDate);
                command.Parameters.AddWithValue("@userId", this._user.Id);
                command.Parameters.AddWithValue("@contactId", this._contact._id);

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
        /// Updates the meeting in the database
        /// </summary>
        /// <returns>true on success</returns>
        public bool UpdateMeeting()
        {

            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("UpdateMeeting", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@meetingId", this._meetingId);
                command.Parameters.AddWithValue("@notes", this._meetingNotes);
                command.Parameters.AddWithValue("@newStartDate", this._meetingStartDate);
                command.Parameters.AddWithValue("@endDate", this._meetingEndDate);
                command.Parameters.AddWithValue("@userId", this._user.Id);
                command.Parameters.AddWithValue("@contactId", this._contact._id);
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
        /// Removes the meeting from the database First delete is soft delete, second delete is hard delete
        /// </summary>
        /// <returns>true on success</returns>
        public bool RemoveMeeting()
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("DeleteMeeting", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@meetingId", this._meetingId);

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
        /// Returns a list of meetings from the database
        /// </summary>
        /// <param name="activeState">whether or not soft deleted. 1=> active 0=> soft deleted</param>
        /// <returns>a list of meetings</returns>
        public List<Meeting> GetMeetings(string searchword, bool activeState, DateTime startInterval, DateTime endInterval)
        {
            List<Meeting> meetings = new List<Meeting>();

            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("RetrieveMeetings", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@userId", this._user.Id);
                command.Parameters.AddWithValue("@activeState", activeState);
                command.Parameters.AddWithValue("@startInterval", startInterval);
                command.Parameters.AddWithValue("@endInterval", endInterval);
                command.Parameters.AddWithValue("@usernameSearch", searchword);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Meeting meeting = new Meeting();
                    meeting._meetingId = Convert.ToInt32(reader["meetingId"]);
                    meeting._meetingNotes = reader["notes"].ToString();
                    meeting._meetingStartDate = Convert.ToDateTime(reader["startDate"]);
                    meeting._meetingEndDate = Convert.ToDateTime(reader["endDate"]);

                    Contact contact = new Contact();
                    contact._phoneNumber = (reader["gsmNumber"]?.ToString() ?? string.Empty);
                    contact._email = (reader["email"]?.ToString() ?? string.Empty);
                    contact._address = (reader["address"]?.ToString() ?? string.Empty);
                    contact._username = (reader["username"]?.ToString() ?? string.Empty);
                    contact._name = (reader["firstName"]?.ToString() ?? string.Empty);
                    contact._surname = (reader["lastName"]?.ToString() ?? string.Empty);
                    contact._id = Convert.ToInt32(reader["contactId"]?.ToString() ?? string.Empty);

                    meeting.Contact = contact;

                    meetings.Add(meeting);
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

            return meetings;
        }

        public List<Meeting> GetPreviousMeetings(string searchword, bool activeState, DateTime startInterval, DateTime endInterval)
        {
            List<Meeting> meetings = new List<Meeting>();

            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("RetrievePreviousMeetings", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@userId", this._user.Id);
                command.Parameters.AddWithValue("@activeState", activeState);
                command.Parameters.AddWithValue("@startInterval", startInterval);
                command.Parameters.AddWithValue("@endInterval", endInterval);
                command.Parameters.AddWithValue("@usernameSearch", searchword);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Meeting meeting = new Meeting();
                    meeting._meetingId = Convert.ToInt32(reader["meetingId"]);
                    meeting._meetingNotes = reader["notes"].ToString();
                    meeting._meetingStartDate = Convert.ToDateTime(reader["startDate"]);
                    meeting._meetingEndDate = Convert.ToDateTime(reader["endDate"]);

                    Contact contact = new Contact();
                    contact._phoneNumber = (reader["gsmNumber"]?.ToString() ?? string.Empty);
                    contact._email = (reader["email"]?.ToString() ?? string.Empty);
                    contact._address = (reader["address"]?.ToString() ?? string.Empty);
                    contact._username = (reader["username"]?.ToString() ?? string.Empty);
                    contact._name = (reader["firstName"]?.ToString() ?? string.Empty);
                    contact._surname = (reader["lastName"]?.ToString() ?? string.Empty);
                    contact._id = Convert.ToInt32(reader["contactId"]?.ToString() ?? string.Empty);

                    meeting.Contact = contact;

                    meetings.Add(meeting);
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

            return meetings;
        }

        /// <summary>
        /// Brings back a soft deleted meeting
        /// </summary>
        /// <returns>true on success</returns>
        public bool BringBackMeeting()
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("BringMeetingBack", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@meetingId", this._meetingId);

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
