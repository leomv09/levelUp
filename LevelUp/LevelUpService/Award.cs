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
        private double m_money;
        private Currency m_currency;
        private string m_type;
        private string m_creationdate;
        private User m_creator;
        private string m_status;

        public Award()
        {
            m_id = 0;
            m_name = String.Empty;
            m_description = String.Empty;
            m_photourl = String.Empty;
            m_amount = 0;
            m_money = 0;
            m_currency = new Currency();
            m_type = String.Empty;
            m_creationdate = DateTime.Today.ToShortDateString();
            m_creator = new User();
            m_status = String.Empty;
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
        public double Money
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
            set { m_creationdate = value; }
        }

        [DataMember]
        public User Creator
        {
            get { return m_creator; }
            set { m_creator = value; }
        }

        [DataMember]
        public string Status
        {
            get { return m_status; }
            set { m_status = value; }
        }

        public override string ToString()
        {
            return m_name;
        }
    }
}