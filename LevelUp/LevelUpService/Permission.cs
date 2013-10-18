using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LevelUpService
{
    [DataContract]
    public class Permission
    {
        private string m_code;
        private string m_description;

        [DataMember]
        public string Code
        {
            get { return m_code; }
            set { }
        }

        [DataMember]
        public string Description
        {
            get { return m_description; }
            set { }
        }
    }
}