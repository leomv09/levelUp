using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LevelUpService
{
    [DataContract]
    public class Authentication
    {
        private bool m_state;

        [DataMember]
        public bool State
        {
            get { return m_state; }
            set { }
        }
    }
}