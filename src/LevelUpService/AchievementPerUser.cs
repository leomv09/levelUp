using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LevelUp.Data
{
    [DataContract]
    public class AchievementPerUser
    {
        private Achievement m_achievement;
        private string m_detail;
        private DateTime m_obtainingdate;
        private User m_creator;

        public AchievementPerUser()
        {
            m_achievement = new Achievement();
            m_detail = String.Empty;
            m_obtainingdate = DateTime.Today;
            m_creator = new User();
        }

        [DataMember]
        public Achievement Achievement
        {
            get { return m_achievement; }
            set { m_achievement = value; }
        }

        [DataMember]
        public string Detail
        {
            get { return m_detail; }
            set { m_detail = value; }
        }

        [DataMember]
        public DateTime ObtainingDate
        {
            get { return m_obtainingdate; }
            set { m_obtainingdate = value; }
        }

        [DataMember]
        public User Creator
        {
            get { return m_creator; }
            set { m_creator = value; }
        }
    }
}