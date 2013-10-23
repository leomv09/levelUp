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

        public Department()
        {
            m_id = 0;
            m_name = String.Empty;
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

        public override string ToString()
        {
            return m_name;
        }
    }
}