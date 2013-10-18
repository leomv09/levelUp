using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LevelUpService
{
    [DataContract]
    public class Rule
    {
        private int m_id;
        private string m_name;
        private string m_description;
        private string m_startdate;
        private string m_enddate;
        private string m_creationdate;
        private User m_creator;
        private string m_status;
        private AchievementPerRule[] m_achievements;
        private Award[] m_awards;

        [DataMember]
        public int ID
        {
            get { return m_id; }
            set { }
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
        public string StartDate
        {
            get { return m_startdate; }
            set { m_startdate = value; }
        }

        [DataMember]
        public string EndDate
        {
            get { return m_enddate; }
            set { m_enddate = value; }
        }

        [DataMember]
        public string CreationDate
        {
            get { return m_creationdate; }
            set { m_creationdate = value; }
        }

        [DataMember]
        public User Creator
        {
            get { return m_creator; }
            set { }
        }

        [DataMember]
        public string Status
        {
            get { return m_status; }
            set { m_status = value; }
        }

        [DataMember]
        public AchievementPerRule[] Achievements
        {
            get { return m_achievements; }
            set { m_achievements = value; }
        }

        [DataMember]
        public Award[] Awards
        {
            get { return m_awards; }
            set { m_awards = value; }
        }
    }
}