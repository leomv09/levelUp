using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LevelUp.Data
{
    [DataContract]
    public class Achievement
    {
        private int m_id;
        private string m_name;
        private string m_description;
        private DateTime m_startdate;
        private DateTime m_enddate;
        private DateTime m_creationdate;
        private User m_creator;
        private int m_maxamount;

        public Achievement()
        {
            m_id = 0;
            m_name = String.Empty;
            m_description = String.Empty;
            m_startdate = DateTime.Today;
            m_enddate = DateTime.Today;
            m_creationdate = DateTime.Today;
            m_creator = new User();
            m_maxamount = 0;
        }

        [DataMember]
        public int ID
        {
            get { return m_id; }
            set { m_id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        [DataMember]
        public string Description
        {
            get { return m_description; }
            set { m_description = value; }
        }

        [DataMember]
        public DateTime StartDate
        {
            get { return m_startdate; }
            set { m_startdate = value; }
        }

        [DataMember]
        public DateTime EndDate
        {
            get { return m_enddate; }
            set { m_enddate = value; }
        }

        [DataMember]
        public DateTime CreationDate
        {
            get { return m_creationdate; }
            set { m_creationdate = value; }
        }

        [DataMember]
        public User Creator
        {
            get { return m_creator; }
            set { m_creator = value; }
        }

        [DataMember]
        public int MaxAmount
        {
            get { return m_maxamount; }
            set { m_maxamount = value; }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}