using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LevelUp.Data
{
    [DataContract]
    public class Authentication
    {
        private bool m_state;
        private User m_user;

        public Authentication()
        {
            m_state = false;
            m_user = new User();
        }

        [DataMember]
        public bool State
        {
            get { return m_state; }
            set { m_state = value; }
        }

        [DataMember]
        public User User
        {
            get { return m_user; }
            set { m_user = value; }
        }
    }
}