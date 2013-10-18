using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LevelUpService
{
    [DataContract]
    public class Department
    {
        private int m_id;
        private string m_name;

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
    }
}