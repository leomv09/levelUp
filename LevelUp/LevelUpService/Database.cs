using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace LevelUpService
{
    public class Database
    {
        private string m_primaryServer;
        private string m_secondaryServer;
        private string m_database;
        private string m_user;
        private string m_password;
        private int m_minpool;
        private int m_maxpool;

        public SqlDataReader ExecStoredProcedure(SqlConnection connection, string spName, 
            string[] spParametersNames, object[] spParametersValues)
        {
            if (spParametersNames.Length != spParametersValues.Length)
            {
                throw new Exception("Inconsistent number of parameters");
            }

            SqlCommand command = new SqlCommand();
            command.CommandText = spName;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = connection;

            for (int i = 0; i < spParametersNames.Length; i++)
            {
                command.Parameters.AddWithValue(spParametersNames[i], spParametersValues[i]);
            }

            connection.Open();
            return command.ExecuteReader();
        }

        public SqlDataReader ExecStoredProcedure(SqlConnection connection, string spName)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = spName;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = connection;

            connection.Open();
            return command.ExecuteReader();
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(GetConnectionString());
        }

        private string GetConnectionString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Data Source=");
            sb.Append(m_primaryServer);
            //sb.Append("Failover Partner=");
            //sb.Append(m_secondaryServer);
            sb.Append(";Initial Catalog=");
            sb.Append(m_database);
            sb.Append(";Min Pool Size=");
            sb.Append(m_minpool);
            sb.Append(";Max Pool Size=");
            sb.Append(m_maxpool);
            sb.Append(";Integrated Security=");
            sb.Append(false);
            sb.Append(";User ID=");
            sb.Append(m_user);
            sb.Append(";Password=");
            sb.Append(m_password);
            return sb.ToString();
        }

        public void SetServers(string primary, string secondary)
        {
            m_primaryServer = primary;
            m_secondaryServer = secondary;
        }

        public void SetAuthentication(string user, string password)
        {
            m_user = user;
            m_password = password;
        }

        public void SetPoolSize(int min, int max)
        {
            m_minpool = min;
            m_maxpool = max;
        }

        public void SetDatabase(string database)
        {
            m_database = database;
        }
    }
}