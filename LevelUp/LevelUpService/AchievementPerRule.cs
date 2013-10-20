using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LevelUpService
{
    [DataContract]
    public class AchievementPerRule
    {
        private Achievement m_achievement;
        private int m_amount;
        private string m_creationdate;
        private User m_creator;

        public AchievementPerRule()
        {
            //m_achievement = new Achievement();
            //m_amount = 0;
            //m_creationdate = DateTime.Today.ToShortDateString();
            //m_creator = new User();
        }

        public static bool IsValid(AchievementPerRule achievement)
        {
            return achievement.Achievement != null;
        }

        [DataMember]
        public Achievement Achievement
        {
            get { return m_achievement; }
            set { m_achievement = value; }
        }

        [DataMember]
        public int Amount
        {
            get { return m_amount; }
            set { m_amount = value; }
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
            set { m_creator = value; }
        }
    }
}