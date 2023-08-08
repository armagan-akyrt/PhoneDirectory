using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Scripts
{
    public class Conference
    {
        private int _conferenceId;
        private int _requesterId;
        private int _requestId;
        private List<int>? _participantIds;
        private ConferenceRoom? _conferenceRoom;
        private DateTime _startDate;
        private DateTime _endDate;

        private string? _topic;
        private string? _description;
        private string? _notes;

        private Connection connection = new Connection();

        #region Getters and Setters
        public int ConferenceId
        {
            get { return _conferenceId; }
            set { _conferenceId = value; }
        }

        public int RequesterId
        {
            get { return _requesterId; }
            set { _requesterId = value; }
        }

        public int RequestId
        {
            get { return _requestId; }
            set { _requestId = value; }
        }

        public List<int>? ParticipantIds
        {
            get { return _participantIds; }
            set { _participantIds = value; }
        }

        public ConferenceRoom? ConferenceRoom
        {
            get { return _conferenceRoom; }
            set { _conferenceRoom = value; }
        }

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public string Topic
        {
            get { return _topic; }
            set { _topic = value; }
        }

        public string? Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string? Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }
        #endregion

        public Conference()
        {
            _conferenceId = 0;
            _requesterId = 0;
            _requestId = 0;
            _participantIds = null;
            _conferenceRoom = null;
            _startDate = DateTime.Now;
            _endDate = DateTime.Now;
            _topic = null;
            _description = null;
            _notes = null;
            _conferenceRoom = new ConferenceRoom();
        }

        public bool CreateConference()
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("ConferenceCreate", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
            
                command.Parameters.AddWithValue("@roomId", _conferenceRoom.RoomId);
                command.Parameters.AddWithValue("@topic", _topic);
                command.Parameters.AddWithValue("@description", _description);
                command.Parameters.AddWithValue("@startDate", _startDate);
                command.Parameters.AddWithValue("@endDate", _endDate);
                command.Parameters.AddWithValue("@notes", _notes);

                SqlParameter conferenceIdParam = new SqlParameter("@conferenceId", System.Data.SqlDbType.Int);
                conferenceIdParam.Direction = System.Data.ParameterDirection.Output;
                command.Parameters.Add(conferenceIdParam);

                command.ExecuteNonQuery();
                this._conferenceId = (int)conferenceIdParam.Value;
            }
            catch (Exception)
            {
                return false;
                throw;
            } 
            finally
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("ConferenceNewRequest", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@conferenceId", _conferenceId);
                command.Parameters.AddWithValue("@requesterId", _requesterId);

                SqlParameter requestIdParam = new SqlParameter("@requestId", System.Data.SqlDbType.Int);
                requestIdParam.Direction = System.Data.ParameterDirection.Output;
                command.Parameters.Add(requestIdParam);

                command.ExecuteNonQuery();
                _requestId = (int)requestIdParam.Value;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                conn.Close();
            }

            try
            {
                conn.Open();


                foreach (int participantId in _participantIds)
                {
                    SqlCommand command = new SqlCommand("ConferenceAddParticipant", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@requestId", _requestId);
                    command.Parameters.AddWithValue("@participantId", participantId);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        public List<Conference> ListParticipantRequsts(int currentUserId)
        {
            List<Conference> conferences = new List<Conference>();
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("ConferenceListPendingParticipants", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@participantId", currentUserId);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Conference tempConference = new Conference();
                    tempConference.ConferenceId = (int)reader["conferenceId"];
                    tempConference.RequesterId = (int)reader["requesterId"];
                    tempConference.RequestId = (int)reader["requestId"];

                    tempConference.Topic = (string)reader["topic"];
                    tempConference.Description = (string)reader["description"];
                    tempConference.Notes = (string)reader["notes"];

                    tempConference.StartDate = (DateTime)reader["startDate"];
                    tempConference.EndDate = (DateTime)reader["endDate"];
                    tempConference.ConferenceRoom.RoomId = (int)reader["roomId"];

                    conferences.Add(tempConference);
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            } 
            finally
            {
                conn.Close();
            }

            return conferences;
        }

        public bool ParticipantResponse(int participantId, bool response)
        {
            SqlConnection conn = connection.GetConnection();
            string sqlProcedure = response ? "ConferenceAcceptRequest" : "ConferenceParticipantRejectRequest";
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlProcedure, conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@participantId", participantId);
                command.Parameters.AddWithValue("@requestId", _requestId);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        public List<Conference> ListPendingApprovals(int currentUserId)
        {
            List<Conference> conferences = new List<Conference>();
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("ConferenceListPendingApprovals", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@overseerId", currentUserId);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Conference tempConference = new Conference();

                    tempConference.ConferenceId = (int)reader["conferenceId"];
                    tempConference.RequesterId = (int)reader["requesterId"];
                    tempConference.RequestId = (int)reader["requestId"];

                    tempConference.Topic = (string)reader["topic"];
                    tempConference.Description = (string)reader["description"];
                    tempConference.Notes = (string)reader["notes"];

                    tempConference.StartDate = (DateTime)reader["startDate"];
                    tempConference.EndDate = (DateTime)reader["endDate"];
                    tempConference.ConferenceRoom.RoomId = (int)reader["roomId"];

                    conferences.Add(tempConference);
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
            finally
            {
                conn.Close();
            }

            return conferences;
        }

        public bool OverseerRequestResponse(int overseerId, bool response)
        {
            string sqlProcedure = response ? "ConferenceOverseerApprove" : "ConferenceRejectRequest";
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlProcedure, conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@overseerId", overseerId);
                command.Parameters.AddWithValue("@requestId", _requestId);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        public bool UpdateConference()
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("ConferenceUpdateData", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@conferenceId", _conferenceId);
                command.Parameters.AddWithValue("@topic", _topic);
                command.Parameters.AddWithValue("@description", _description);
                command.Parameters.AddWithValue("@notes", _notes);
                command.Parameters.AddWithValue("@startDate", _startDate);
                command.Parameters.AddWithValue("@endDate", _endDate);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        public List<Notification> ListNotifications(int currentUserId)
        {
            List<Notification> list = new List<Notification>();
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("ConferenceListNotifications", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@participantId", currentUserId);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Notification temp = new Notification();
                    temp.Id = (int)reader["id"];
                    temp.UserId = (int)reader["userId"];
                    temp.Topic = (string)reader["topic"];
                    temp.Description = (string)reader["description"];
                    temp.Status = (string)reader["status"];

                    list.Add(temp);
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }

            return list;

        }

        public bool ClearNotifications(int userId)
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("ConferenceClearNotifications", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@userId", userId);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
                throw;
            } 
            finally
            {
                conn.Close();
            }

            return true;
        }

    }
}
