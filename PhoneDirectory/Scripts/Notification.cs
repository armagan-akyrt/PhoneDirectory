using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Scripts
{
    public class Notification
    {
        private int _id;
        private int _userId;
        private string _topic;
        private string _description;
        private string _status;


        #region Getters and Setters
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string Topic
        {
            get { return _topic; }
            set { _topic = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        #endregion

        public Notification()
        {
            this._id = 0;
            this._userId = 0;
            this._topic = "";
            this._description = "";
            this._status = "";
        }


    }


}
