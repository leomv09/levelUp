using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LevelUp.Data
{
    [DataContract]
    public class Job
    {
        private int m_id;
        private string m_name;

        public Job()
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