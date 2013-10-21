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

        public Department[] GetDepartments()
        {
            SqlConnection connection = m_db.CreateConnection();
            SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetDepartments");
            List<Department> list = new List<Department>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add(new Department() { ID=reader.GetInt32(0), Name=reader.GetString(1) });
                }
            }

            connection.Close();
            return list.ToArray();
        }

        public Achievement[] GetDepartmentAchievements(int departmentID)
        {
            SqlConnection connection = m_db.CreateConnection();
            SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetDepartmentAchievements",
                new string[] { "@DepartmentID" }, new object[] { departmentID });
            List<Achievement> list = new List<Achievement>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add(GetAchievementByID(reader.GetInt32(reader.GetOrdinal("ID"))));
                }
            }

            connection.Close();
            return list.ToArray();
        }

        public Award[] GetDepartmentAwards(int departmentID)
        {
            SqlConnection connection = m_db.CreateConnection();
            SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetDepartmentAwards",
                new string[] { "@DepartmentID" }, new object[] { departmentID });
            List<Award> list = new List<Award>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add( GetAwardByID(reader.GetInt32(reader.GetOrdinal("ID"))) );
                }
            }

            connection.Close();
            return list.ToArray();
        }

        public Rule[] GetDepartmentRules(int departmentID)
        {
            SqlConnection connection = m_db.CreateConnection();
            SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetDepartmentRules",
                new string[] { "@DepartmentID" }, new object[] { departmentID } );
            List<Rule> list = new List<Rule>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add(
                        new Rule()
                        { 
                            ID = reader.GetInt32(reader.GetOrdinal("ID")), 
                            Name =  Parse_String(reader["Nombre"]),
                            Description = Parse_String(reader["Descripcion"]),
                            StartDate = DateTime.Parse(Parse_String(reader["FechaInicio"])),
                            EndDate = DateTime.Parse(Parse_String(reader["FechaFinal"])),
                            Achievements = GetRuleAchievements(reader.GetInt32(reader.GetOrdinal("ID"))),
                            Awards = GetRuleAwards(reader.GetInt32(reader.GetOrdinal("ID")))
                        }
                    );
                }
            }

            connection.Close();
            return list.ToArray();
        }

        public void AddRuleToDepartment(int ruleID, int departmentID)
        {
            SqlConnection connection = m_db.CreateConnection();

            m_db.ExecStoredProcedure(connection, "AddRuleToDepartment",
                new string[] { "@RuleID", "@DepartmentID" }, new object[] { ruleID, departmentID });

            connection.Close();
        }

        public int CreateRule(Rule rule)
        {
            SqlConnection connection = m_db.CreateConnection();

            SqlDataReader reader = m_db.ExecStoredProcedure(connection, "AddRule",
                new string[] { "@Name", "@Description", "@StartDate", "@EndDate", "@CreationDate", "@CreatorID" },
                new object[] { rule.Name, rule.Description, rule.StartDate, rule.EndDate, rule.CreationDate, rule.Creator.ID });

            int ruleID = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ruleID = Parse_Int(reader["RuleID"], 0);
                }
            }

            foreach (AchievementPerRule ach in rule.Achievements)
            {
                SqlConnection connection2 = m_db.CreateConnection();
                m_db.ExecStoredProcedure(connection2, "AddAchievementToRule",
                new string[] { "@RuleID", "@AchievementID", "@CreatorID", "@Amount", "@CreationDate" },
                new object[] { ruleID, ach.Achievement.ID, ach.Creator.ID, ach.Amount, ach.CreationDate });
                connection2.Close();
            }

            foreach (Award award in rule.Awards)
            {
                SqlConnection connection2 = m_db.CreateConnection();
                m_db.ExecStoredProcedure(connection2, "AddAwardToRule",
                new string[] { "@RuleID", "@AwardID" },
                new object[] { ruleID, award.ID });
                connection2.Close();
            }

            connection.Close();
            return ruleID;
        }

        public void DeleteRuleFromDepartment(int ruleID, int departmentID)
        {
            SqlConnection connection = m_db.CreateConnection();

            m_db.ExecStoredProcedure(connection, "DeleteRuleFromDepartment",
                new string[] { "@RuleID", "@DepartmentID" }, new object[] { ruleID, departmentID });

            connection.Close();
        }

        public void UpdateRule(Rule rule)
        {
            SqlConnection connection = m_db.CreateConnection();

            m_db.ExecStoredProcedure(connection, "UpdateRule",
                new string[] { "@RuleID", "@Name", "@Description", "@StartDate", "@EndDate" },
                new object[] { rule.ID, rule.Name, rule.Description, rule.StartDate, rule.EndDate });

            foreach (AchievementPerRule ach in rule.Achievements)
            {
                SqlConnection connection2 = m_db.CreateConnection();
                m_db.ExecStoredProcedure(connection2, "AddAchievementToRule",
                new string[] { "@RuleID", "@AchievementID", "@CreatorID", "@Amount", "@CreationDate" },
                new object[] { rule.ID, ach.Achievement.ID, ach.Creator.ID, ach.Amount, ach.CreationDate });
                connection2.Close();
            }

            foreach (Award award in rule.Awards)
            {
                SqlConnection connection2 = m_db.CreateConnection();
                m_db.ExecStoredProcedure(connection2, "AddAwardToRule",
                new string[] { "@RuleID", "@AwardID" },
                new object[] { rule.ID, award.ID });
                connection2.Close();
            }

            connection.Close();
        }

        private AchievementPerRule[] GetRuleAchievements(int ruleID)
        {
            SqlConnection connection = m_db.CreateConnection();
            SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetRuleAchievements",
                new string[] { "@RuleID" }, new object[] { ruleID });
            List<AchievementPerRule> list = new List<AchievementPerRule>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add(
                        new AchievementPerRule()
                        {
                            Achievement = GetAchievementByID( reader.GetInt32(reader.GetOrdinal("ID")) ),
                            Amount =  Parse_Int(reader["Cantidad"], 0)
                        }
                    );
                }
            }

            connection.Close();
            return list.ToArray();
        }

        private Award[] GetRuleAwards(int ruleID)
        {
            SqlConnection connection = m_db.CreateConnection();
            SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetRuleAwards",
                new string[] { "@RuleID" }, new object[] { ruleID });
            List<Award> list = new List<Award>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add(GetAwardByID(reader.GetInt32(reader.GetOrdinal("ID"))));
                }
            }

            connection.Close();
            return list.ToArray();
        }

        private Achievement GetAchievementByID(int achievementID)
        {
            SqlConnection connection = m_db.CreateConnection();

            SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetAchievementByID",
                new string[] { "@AchievementID" }, new object[] { achievementID });

            Achievement result = new Achievement();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    result = new Achievement()
                    {
                        ID = reader.GetInt32(reader.GetOrdinal("ID")),
                        Name = Parse_String(reader["Nombre"]),
                        Description = Parse_String(reader["Descripcion"]),
                        StartDate = Parse_DateTime(reader["FechaInicio"]),
                        EndDate = Parse_DateTime(reader["FechaFinal"]),
                        MaxAmount = Parse_Int(reader["NumMaximo"], int.MaxValue)
                    };
                }
            }

            connection.Close();
            return result;
        }

        private Award GetAwardByID(int awardID)
        {
            SqlConnection connection = m_db.CreateConnection();
            SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetAwardByID",
                new string[] { "@AwardID" }, new object[] { awardID });
            Award result = new Award();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    result = new Award()
                    {
                        ID = reader.GetInt32(reader.GetOrdinal("ID")),
                        Name = Parse_String(reader["Nombre"]),
                        Description = Parse_String(reader["Descripcion"]),
                        PhotoUrl = Parse_String(reader["Foto"]),
                        Amount = Parse_Int(reader["Cantidad"], 0),
                        Money = Parse_Double(reader["Monto"], 0.0),
                        Type = Parse_String(reader["Tipo"]),
                        Currency = GetCurrencyByName( Parse_String(reader["Moneda"]) ),
                    };
                }
            }

            connection.Close();
            return result;
        }

        private Currency GetCurrencyByName(string name)
        {
            SqlConnection connection = m_db.CreateConnection();
            SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetCurrencyByName",
                new string[] { "@Name" }, new object[] { name });
            Currency result = new Currency();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    result = new Currency()
                    {
                        ID = Parse_Int(reader["ID"],0),
                        Name =  Parse_String(reader["Nombre"]),
                        Code = Parse_String(reader["Codigo"]),
                        Symbol = Parse_String(reader["Simbolo"])
                    };
                }
            }

            connection.Close();
            return result;
        }

        public string[] GetAllUsernames()
        {
            SqlConnection connection = m_db.CreateConnection();
            SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetAllUsernames");
            List<string> list = new List<string>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
            }

            connection.Close();
            return list.ToArray();
        }

        public User GetUserByUsername(string username)
        {
            SqlConnection connection = m_db.CreateConnection();
            SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetUser", 
                new string[] { "@Username" }, new object[] { "admin" });
            User user = new User();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user.Name = reader.GetString(reader.GetOrdinal("Nombre"));
                    user.Username = reader.GetString(reader.GetOrdinal("Username"));
                }
            }

            connection.Close();
            return user;
        }

        private string Parse_String(object value)
        {
            return (value == DBNull.Value) ? string.Empty : value.ToString();
        }

        private DateTime Parse_DateTime(object value)
        {
            return (value == DBNull.Value) ? DateTime.Today : (DateTime) value;
        }

        private int Parse_Int(object value, int defaultValue)
        {
            return (value == DBNull.Value) ? defaultValue : Convert.ToInt32(value);
        }

        private double Parse_Double(object value, double defaultValue)
        {
            return (value == DBNull.Value) ? defaultValue : Convert.ToDouble(value);
        }
    }
}