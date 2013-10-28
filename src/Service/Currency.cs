using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LevelUp.Data
{
    [DataContract]
    public class Currency
    {
        private int m_id;
        private string m_name;
        private string m_symbol;
        private string m_code;

        public Currency()
        {
            m_id = 0;
            m_name = String.Empty;
            m_symbol = String.Empty;
            m_code = String.Empty;
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

        [DataMember]
        public string Symbol
        {
            get { return m_symbol; }
            set { m_symbol = value; }
        }

        [DataMember]
        public string Code
        {
            get { return m_code; }
            set { m_code = value; }
        }

        public override string ToString()
        {
            return m_name;
        }
    }
}