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

        public Permission()
        {
            m_code = String.Empty;
            m_description = String.Empty;
        }

        [DataMember]
        public string Code
        {
            get { return m_code; }
            set { m_code = value; }
        }

        [DataMember]
        public string Description
        {
            get { return m_description; }
            set { m_description = value; }
        }

        public override string ToString()
        {
            return m_code;
        }
    }
}