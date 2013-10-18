using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LevelUpService
{
    [DataContract]
    public class AchievementPerUser
    {
        private Achievement m_achievement;
        private string m_detail;
        private string m_obtainingdate;
        private User m_creator;

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
        public string ObtainingDate
        {
            get { return m_obtainingdate; }
            set { }
        }

        [DataMember]
        public User Creator
        {
            get { return m_creator; }
            set { }
        }
    }
}