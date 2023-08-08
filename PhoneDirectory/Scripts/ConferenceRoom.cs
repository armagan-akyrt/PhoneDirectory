using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Scripts
{
    public class ConferenceRoom
    {
        private int _roomId;
        private int _overseerId;
        private int _conferenceId;
        private int _roomCapacity;
        private bool _isEmpty;
        private string? _meetingTopic;
        private string? _meetingDescription;
        private DateTime _startDate;
        private DateTime _endDate;
        private List<string>? _participantNames;

        private Connection connection = new Connection();


        #region Getters and Setters
        public int RoomId
        {
            get { return _roomId; }
            set { _roomId = value; }
        }

        public int OverseerId
        {
            get { return _overseerId; }
            set { _overseerId = value; }
        }

        public int ConferenceId
        {
            get { return _conferenceId; }
            set { _conferenceId = value; }
        }

        public int RoomCapacity
        {
            get { return _roomCapacity; }
            set { _roomCapacity = value; }
        }

        public bool IsEmpty
        {
            get { return _isEmpty; }
            set { _isEmpty = value; }
        }

        public string MeetingTopic
        {
            get { return _meetingTopic; }
            set { _meetingTopic = value; }
        }

        public string MeetingDescription
        {
            get { return _meetingDescription; }
            set { _meetingDescription = value; }
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

        public List<string> ParticipantNames
        {
            get { return _participantNames; }
            set { _participantNames = value; }
        }

        #endregion

        public ConferenceRoom()
        {
            _roomId = 0;
            _overseerId = 0;
            _conferenceId = 0;
            _roomCapacity = 0;
            _isEmpty = true;
            _meetingTopic = null;
            _meetingDescription = null;
            _startDate = DateTime.Now;
            _endDate = DateTime.Now;
            _participantNames = null;
        }

        public bool CreateConferenceRoom()
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("ConferenceNewMeetingRoom", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@overseerId", this._overseerId);
                command.Parameters.AddWithValue("@roomCapacity", this._roomCapacity);

                SqlParameter roomIdParam = new SqlParameter("@roomId", System.Data.SqlDbType.Int);
                roomIdParam.Direction = System.Data.ParameterDirection.Output;
                command.Parameters.Add(roomIdParam);

                command.ExecuteNonQuery();
                _roomId = (int)roomIdParam.Value;
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

        public bool RemoveConferenceRoom()
        {
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("RemoveConferenceRoom", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@roomId", this._roomId);

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

        public List<ConferenceRoom> GetConferenceRooms()
        {
            List<ConferenceRoom> conferenceRooms = new List<ConferenceRoom>();
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("ConferenceListMeetingRooms", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ConferenceRoom conferenceRoom = new ConferenceRoom();
                    conferenceRoom._roomId = Convert.ToInt32(reader["roomId"]);
                    conferenceRoom._overseerId = Convert.ToInt32(reader["overseerId"]);
                    conferenceRoom._roomCapacity = Convert.ToInt32(reader["capacity"]);
                    conferenceRoom._isEmpty = reader["roomStatus"]?.ToString().Equals("In Use") ?? true;
                    if (!IsEmpty)
                    {
                        conferenceRoom._conferenceId = Convert.ToInt32(reader["conferenceId"]);
                        conferenceRoom._meetingTopic = reader["topic"].ToString();
                        conferenceRoom._meetingDescription = reader["description"].ToString();
                        conferenceRoom._startDate = (DateTime)reader["startDate"];
                        conferenceRoom._endDate = (DateTime)reader["end"];
                    }

                    conferenceRooms.Add(conferenceRoom);
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

            return conferenceRooms;
        }

        public List<string> ListParticipants()
        {
            List<string> participants = new List<string>();
            SqlConnection conn = connection.GetConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("ConferenceListParticipants", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@conferenceId", this._conferenceId);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    participants.Add(reader.GetString(0));
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

            return participants;
        }
    }

}



