using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LevelUpService
{
    [DataContract]
    public class Currency
    {
        private int m_id;
        private string m_name;
        private string m_symbol;
        private string m_code;

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
            set { }
        }

        [DataMember]
        public string Symbol
        {
            get { return m_symbol; }
            set { }
        }

        [DataMember]
        public string Code
        {
            get { return m_code; }
            set { }
        }
    }
}