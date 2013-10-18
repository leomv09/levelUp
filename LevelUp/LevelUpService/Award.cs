using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LevelUpService
{
    [DataContract]
    public class Award
    {
        private int m_id;
        private string m_name;
        private string m_description;
        private string m_photourl;
        private int m_amount;
        private float m_money;
        private Currency m_currency;
        private string m_type;
        private string m_creationdate;
        private User m_creator;
        private string m_status;

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

        [DataMember]
        public string Description
        {
            get { return m_description; }
            set { m_description = value; }
        }

        [DataMember]
        public string PhotoUrl
        {
            get { return m_photourl; }
            set { m_photourl = value; }
        }

        [DataMember]
        public int Amount
        {
            get { return m_amount; }
            set { m_amount = value; }
        }

        [DataMember]
        public float Money
        {
            get { return m_money; }
            set { m_money = value; }
        }

        [DataMember]
        public Currency Currency
        {
            get { return m_currency; }
            set { m_currency = value; }
        }

        [DataMember]
        public string Type
        {
            get { return m_type; }
            set { m_type = value; }
        }

        [DataMember]
        public string CreationDate
        {
            get { return m_creationdate; }
            set { }
        }

        [DataMember]
        public User Creator
        {
            get { return m_creator; }
            set { }
        }

        [DataMember]
        public string Status
        {
            get { return m_status; }
            set { m_status = value; }
        }
    }
}