using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LevelUpService
{
    public class DataAccess
    {
        private Database m_db;

        public DataAccess()
        {
            m_db = new Database();
            m_db.SetServers("LAPTOP-JOSE", "");
            m_db.SetDatabase("LevelUp");
            m_db.SetAuthentication("LevelUp_App", "admin");
            m_db.SetPoolSize(0, 4);
        }

        public User GetUserByUsername(string username)
        {
            SqlConnection connection = m_db.CreateConnection();
            SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetUser", 
                new string[] { "@Username" }, new string[] { "admin" });
            User user = new User();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user.Name = reader.GetString(1);
                }
            }

            connection.Close();
            return user;
        }
    }
}