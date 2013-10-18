using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LevelUpService
{
    [DataContract]
    public class User
    {
        private int m_id;
        private string m_name;
        private string m_lastname1;
        private string m_lastname2;
        private string m_username;
        private string m_photourl;
        private string m_status;
        private string m_genre;

        [DataMember]
        public int ID
        {
            get { return m_id;}
            set { }
        }

        [DataMember]
        public string Name
        {
            get { return m_name;}
            set { m_name = value;}
        }

        [DataMember]
        public string LastName1
        {
            get { return m_lastname1;}
            set { m_lastname1 = value;}
        }

        [DataMember]
        public string LastName2
        {
            get { return m_lastname2;}
            set { m_lastname2 = value;}
        }

        [DataMember]
        public string Username
        {
            get { return m_username;}
            set { m_username = value;}
        }

        [DataMember]
        public string PhotoUrl
        {
            get { return m_photourl;}
            set { m_photourl = value;}
        }

        [DataMember]
        public string Status
        {
            get { return m_status;}
            set { m_status = value;}
        }

        [DataMember]
        public string Genre
        {
            get { return m_genre;}
            set { m_genre = value;}
        }

    }
}