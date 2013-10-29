using LevelUp.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LevelUp.Database
{
    public class DataAccess
    {
        private Database m_db;

        public DataAccess()
        {
            m_db = new Database();
            m_db.SetServers("DATABASE1", "DATABASE2");
            m_db.SetDatabase("LevelUp");
            m_db.SetAuthentication("LU_App", "admin");
            m_db.SetPoolSize(0, 4);
        }

        public Department[] GetDepartments()
        {
            List<Department> list = new List<Department>();

            using (SqlConnection connection = m_db.CreateConnection())
            {
                SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetDepartments");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(
                            new Department()
                            { 
                                ID = reader.GetInt32(reader.GetOrdinal("ID")), 
                                Name = reader.GetString(reader.GetOrdinal("Departamento")) 
                            }
                        );
                    }
                }
            }

            return list.ToArray();
        }

        public Achievement[] GetDepartmentAchievements(int departmentID)
        {
            List<Achievement> list = new List<Achievement>();

            using (SqlConnection connection = m_db.CreateConnection())
            {
                SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetDepartmentAchievements",
                    new string[] { "@DepartmentID" }, new object[] { departmentID });

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(
                            new Achievement()
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                Name = reader.GetString(reader.GetOrdinal("Nombre")),
                                Description = reader.GetString(reader.GetOrdinal("Descripcion")),
                                StartDate = reader.GetDateTime(reader.GetOrdinal("FechaInicio")),
                                EndDate = reader.GetDateTime(reader.GetOrdinal("FechaFinal")),
                                MaxAmount = reader.GetInt32(reader.GetOrdinal("NumMaximo"))
                            }
                        );
                    }
                }
            }

            return list.ToArray();
        }

        public Award[] GetDepartmentAwards(int departmentID)
        {
            List<Award> list = new List<Award>();

            using (SqlConnection connection = m_db.CreateConnection())
            {
                SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetDepartmentAwards",
                    new string[] { "@DepartmentID" }, new object[] { departmentID });

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(
                            new Award()
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                Name = reader.GetString(reader.GetOrdinal("Nombre")),
                                Description = reader.GetString(reader.GetOrdinal("Descripcion")),
                                PhotoUrl = reader.GetString(reader.GetOrdinal("Foto")),
                                Amount = reader.GetInt32(reader.GetOrdinal("Cantidad")),
                                Money = reader.GetDouble(reader.GetOrdinal("Monto")),
                                Type = reader.GetString(reader.GetOrdinal("Tipo")),
                                Currency = GetCurrencyByName(reader.GetString(reader.GetOrdinal("Moneda"))),
                            }
                        );
                    }
                }
            }

            return list.ToArray();
        }

        public Rule[] GetDepartmentRules(int departmentID)
        {
            List<Rule> list = new List<Rule>();

            using (SqlConnection connection = m_db.CreateConnection())
            {
                SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetDepartmentRules",
                    new string[] { "@DepartmentID" }, new object[] { departmentID });

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(
                            new Rule()
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                Name = reader.GetString(reader.GetOrdinal("Nombre")),
                                Description = reader.GetString(reader.GetOrdinal("Descripcion")),
                                StartDate = reader.GetDateTime(reader.GetOrdinal("FechaInicio")),
                                EndDate = reader.GetDateTime(reader.GetOrdinal("FechaFinal")),
                                Achievements = GetRuleAchievements(reader.GetInt32(reader.GetOrdinal("ID"))),
                                Awards = GetRuleAwards(reader.GetInt32(reader.GetOrdinal("ID")))
                            }
                        );
                    }
                }
            }

            return list.ToArray();
        }

        public void AddRuleToDepartment(int ruleID, int departmentID)
        {
            using (SqlConnection connection = m_db.CreateConnection())
            {
                m_db.ExecStoredProcedure(connection, "AddRuleToDepartment",
                    new string[] { "@RuleID", "@DepartmentID" }, new object[] { ruleID, departmentID });
            }
        }

        public int CreateRule(Rule rule)
        {
            int ruleID = 0;

            using (SqlConnection connection = m_db.CreateConnection())
            {
                SqlDataReader reader = m_db.ExecStoredProcedure(connection, "AddRule",
                    new string[] { "@Name", "@Description", "@StartDate", "@EndDate", "@CreatorID" },
                    new object[] { rule.Name, rule.Description, rule.StartDate, rule.EndDate, rule.Creator.ID });


                if (reader.HasRows)
                {
                    reader.Read();
                    ruleID = Parse_Int(reader["RuleID"], 0);
                    rule.ID = ruleID;
                }
            }

            foreach (AchievementPerRule ach in rule.Achievements)
            {
                using (SqlConnection connection = m_db.CreateConnection())
                {
                    m_db.ExecStoredProcedure(connection, "AddAchievementToRule",
                    new string[] { "@RuleID", "@AchievementID", "@Amount" },
                    new object[] { ruleID, ach.Achievement.ID, ach.Amount });
                }
            }

            foreach (Award award in rule.Awards)
            {
                using (SqlConnection connection = m_db.CreateConnection())
                {
                    m_db.ExecStoredProcedure(connection, "AddAwardToRule",
                    new string[] { "@RuleID", "@AwardID" },
                    new object[] { ruleID, award.ID });
                }
            }

            return ruleID;
        }

        public void DeleteRuleFromDepartment(int ruleID, int departmentID)
        {
            using (SqlConnection connection = m_db.CreateConnection())
            {
                 m_db.ExecStoredProcedure(connection, "DeleteRuleFromDepartment",
                    new string[] { "@RuleID", "@DepartmentID" }, new object[] { ruleID, departmentID });
            }
        }

        public Department GetUserDepartment(string username)
        {
            Department department = new Department();

            using (SqlConnection connection = m_db.CreateConnection())
            {
                 SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetUserDepartment",
                    new string[] { "@Username" }, new object[] { username });

                 if (reader.HasRows)
                 {
                     reader.Read();
                     department.ID = Parse_Int(reader["ID"], 0);
                     department.Name = reader.GetString(reader.GetOrdinal("Departamento"));
                 }
            }

            return department;
        }

        public Job GetUserJob(string username)
        {
            Job job = new Job();

            using (SqlConnection connection = m_db.CreateConnection())
            {
                 SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetUserJob",
                    new string[] { "@Username" }, new object[] { username });

                 if (reader.HasRows)
                 {
                     reader.Read();
                     job.ID = Parse_Int(reader["ID"], 0);
                     job.Name = reader.GetString(reader.GetOrdinal("Puesto"));
                 }
            }

            return job;
        }

        public AchievementPerUser[] GetUserAchievements(string username)
        {
            List<AchievementPerUser> list = new List<AchievementPerUser>();

            using (SqlConnection connection = m_db.CreateConnection())
            {
                SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetUserAchievements",
                    new string[] { "@Username" }, new object[] { username });

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(
                            new AchievementPerUser()
                            {
                                Achievement = new Achievement()
                                {
                                    ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                    Name = reader.GetString(reader.GetOrdinal("Nombre")),
                                    Description = reader.GetString(reader.GetOrdinal("Descripcion")),
                                    StartDate = reader.GetDateTime(reader.GetOrdinal("FechaInicio")),
                                    EndDate = reader.GetDateTime(reader.GetOrdinal("FechaFinal")),
                                    MaxAmount = reader.GetInt32(reader.GetOrdinal("NumMaximo"))
                                },
                                Detail = reader.GetString(reader.GetOrdinal("Detalle"))
                            }
                        );
                    }
                }
            }

            return list.ToArray();
        }

        public void AddAchievementToUser(AchievementPerUser achievement, string username)
        {
            using (SqlConnection connection = m_db.CreateConnection())
            {
                SqlDataReader reader = m_db.ExecStoredProcedure(connection, "AddAchievementToUser",
                    new string[] { "@AchievementID", "@Username", "@CreatorUsername", "@Details" }, 
                    new object[] { achievement.Achievement.ID, username, achievement.Creator.Username, achievement.Detail });
            }
        }

        public void RemoveAchievementFromUser(AchievementPerUser achievement, string username)
        {
            using (SqlConnection connection = m_db.CreateConnection())
            {
                SqlDataReader reader = m_db.ExecStoredProcedure(connection, "RemoveAchievementFromUser",
                    new string[] { "@AchievementID", "@Username" },
                    new object[] { achievement.Achievement.ID, username } );
            }
        }

        public void UpdateRule(Rule rule)
        {
            using (SqlConnection connection = m_db.CreateConnection())
            {
                m_db.ExecStoredProcedure(connection, "UpdateRule",
                    new string[] { "@RuleID", "@Name", "@Description", "@StartDate", "@EndDate" },
                    new object[] { rule.ID, rule.Name, rule.Description, rule.StartDate, rule.EndDate });
            }

            using (SqlConnection connection = m_db.CreateConnection())
            {
                m_db.ExecStoredProcedure(connection, "DeleteRuleAchievements",
                    new string[] { "@RuleID" },
                    new object[] { rule.ID });
            }
            foreach (AchievementPerRule ach in rule.Achievements)
            {
                using (SqlConnection connection = m_db.CreateConnection())
                {
                    m_db.ExecStoredProcedure(connection, "AddAchievementToRule",
                    new string[] { "@RuleID", "@AchievementID", "@Amount" },
                    new object[] { rule.ID, ach.Achievement.ID, ach.Amount });
                }
            }

            using (SqlConnection connection = m_db.CreateConnection())
            {
                m_db.ExecStoredProcedure(connection, "DeleteRuleAwards",
                    new string[] { "@RuleID" },
                    new object[] { rule.ID });
            }
            foreach (Award award in rule.Awards)
            {
                using (SqlConnection connection = m_db.CreateConnection())
                {
                    m_db.ExecStoredProcedure(connection, "AddAwardToRule",
                    new string[] { "@RuleID", "@AwardID" },
                    new object[] { rule.ID, award.ID });
                }
            }
        }

        private AchievementPerRule[] GetRuleAchievements(int ruleID)
        {
            List<AchievementPerRule> list = new List<AchievementPerRule>();

            using (SqlConnection connection = m_db.CreateConnection())
            {
                SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetRuleAchievements",
                    new string[] { "@RuleID" }, new object[] { ruleID });

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(
                            new AchievementPerRule()
                            {
                                Achievement = new Achievement()
                                {
                                    ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                    Name = reader.GetString(reader.GetOrdinal("Nombre")),
                                    Description = reader.GetString(reader.GetOrdinal("Descripcion")),
                                    StartDate = reader.GetDateTime(reader.GetOrdinal("FechaInicio")),
                                    EndDate = reader.GetDateTime(reader.GetOrdinal("FechaFinal")),
                                    MaxAmount = reader.GetInt32(reader.GetOrdinal("NumMaximo"))
                                },
                                Amount = reader.GetInt32(reader.GetOrdinal("Cantidad"))
                            }
                        );
                    }
                }
            }

            return list.ToArray();
        }

        private Award[] GetRuleAwards(int ruleID)
        {
            List<Award> list = new List<Award>();

            using (SqlConnection connection = m_db.CreateConnection())
            {
                SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetRuleAwards",
                    new string[] { "@RuleID" }, new object[] { ruleID });

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(
                            new Award()
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                Name = reader.GetString(reader.GetOrdinal("Nombre")),
                                Description = reader.GetString(reader.GetOrdinal("Descripcion")),
                                PhotoUrl = reader.GetString(reader.GetOrdinal("Foto")),
                                Amount = reader.GetInt32(reader.GetOrdinal("Cantidad")),
                                Money = reader.GetDouble(reader.GetOrdinal("Monto")),
                                Type = reader.GetString(reader.GetOrdinal("Tipo")),
                                Currency = GetCurrencyByName(reader.GetString(reader.GetOrdinal("Moneda"))),
                            }    
                        );
                    }
                }
            }

            return list.ToArray();
        }

        private Currency GetCurrencyByName(string name)
        {
            Currency result = null;

            using (SqlConnection connection = m_db.CreateConnection())
            {
                SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetCurrencyByName",
                    new string[] { "@Name" }, new object[] { name });
                
                if (reader.HasRows)
                {
                    reader.Read();
                    result = new Currency()
                    {
                        ID = reader.GetInt32(reader.GetOrdinal("ID")),
                        Name = reader.GetString(reader.GetOrdinal("Nombre")),
                        Code = reader.GetString(reader.GetOrdinal("Codigo")),
                        Symbol = reader.GetString(reader.GetOrdinal("Simbolo"))
                    };
                }
            }

            return result;
        }

        public string[] GetAllUsernames()
        {
            List<string> list = new List<string>();

            using (SqlConnection connection = m_db.CreateConnection())
            {
                SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetAllUsernames");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(reader.GetOrdinal("Username")));
                    }
                }
            }

            return list.ToArray();
        }

        public User GetUserByUsername(string username)
        {
            User user = null;

            using (SqlConnection connection = m_db.CreateConnection())
            {
                SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetUserByUsername",
                    new string[] { "@Username" }, new object[] { username });
                
                if (reader.HasRows)
                {
                    reader.Read();
                    user = new User()
                    {
                        ID = reader.GetInt32(reader.GetOrdinal("ID")),
                        Name = reader.GetString(reader.GetOrdinal("Nombre")),
                        LastName1 = reader.GetString(reader.GetOrdinal("Apellido1")),
                        LastName2 = reader.GetString(reader.GetOrdinal("Apellido2")),
                        Username = reader.GetString(reader.GetOrdinal("Username")),
                        PhotoUrl = reader.GetString(reader.GetOrdinal("Foto")),
                        Genre = reader.GetString(reader.GetOrdinal("Genero"))
                    };
                }
            }

            return user;
        }

        public string[] GetAwardTypes()
        {
            List<string> list = new List<string>();

            using (SqlConnection connection = m_db.CreateConnection())
            {
                SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetAwardTypes");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(reader.GetOrdinal("Tipo")));
                    }
                }
            }

            return list.ToArray();
        }

        public bool CheckAuthentication(string username, string password_hash)
        {
            bool isValid = false;

            using (SqlConnection connection = m_db.CreateConnection())
            {
                SqlDataReader reader = m_db.ExecStoredProcedure(connection, "CheckUserAuthentication",
                    new string[] { "@Username", "@Password" }, new object[] { username, password_hash });

                if (reader.HasRows)
                {
                    reader.Read();
                    isValid = reader.GetBoolean(reader.GetOrdinal("IsValid"));
                }
            }

            return isValid;
        }

        public Currency[] GetAllCurrency()
        {
            List<Currency> list = new List<Currency>();

            using (SqlConnection connection = m_db.CreateConnection())
            {
                SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetAllCurrency");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(
                            new Currency()
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                Name = reader.GetString(reader.GetOrdinal("Nombre")),
                                Code = reader.GetString(reader.GetOrdinal("Codigo")),
                                Symbol = reader.GetString(reader.GetOrdinal("Simbolo"))
                            }
                        );
                    }
                }
            }

            return list.ToArray();
        }

        public Permission[] GetUserPermissions(string username)
        {
            List<Permission> list = new List<Permission>();

            using (SqlConnection connection = m_db.CreateConnection())
            {
                SqlDataReader reader = m_db.ExecStoredProcedure(connection, "GetUserPermissions",
                    new string[]{ "@Username" }, new object[] { username });

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(
                            new Permission()
                            {
                                Code = reader.GetString(reader.GetOrdinal("Codigo")),
                                Description = reader.GetString(reader.GetOrdinal("Descripcion")),
                            }
                        );
                    }
                }
            }

            return list.ToArray();
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