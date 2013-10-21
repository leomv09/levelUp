using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel.Activation;
using System.Data.SqlClient;

namespace LevelUpService
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service : IService
    {
        private DataAccess m_da;

        public Service()
        {
            m_da = new DataAccess();
        }

        public Department[] GetDepartments()
        {
            return m_da.GetDepartments();
        }

        public Rule[] GetDepartmentRules(string departmentID)
        {
            Rule[] result = new Rule[] { };
            int id;

            if (int.TryParse(departmentID, out id))
            {
                result = m_da.GetDepartmentRules(id);
            }

            return result;
        }

        public void AddRuleToDepartment(Rule rule, string departmentID)
        {
            int department_id;

            if (int.TryParse(departmentID, out department_id))
            {
                if (rule.ID == 0)
                {
                    rule.ID = m_da.CreateRule(rule);
                }
                m_da.AddRuleToDepartment(rule.ID, department_id);
            }
        }

        public void DeleteRuleFromDepartment(Rule rule, string departmentID)
        {
            int department_id;

            if (int.TryParse(departmentID, out department_id))
            {
                m_da.DeleteRuleFromDepartment(rule.ID, department_id);
            }
        }

        public Achievement[] GetDepartmentAchievements(string departmentID)
        {
            Achievement[] result = new Achievement[] { };
            int id;

            if (int.TryParse(departmentID, out id))
            {
                result = m_da.GetDepartmentAchievements(id);
            }

            return result;
        }

        public Award[] GetDepartmentAwards(string departmentID)
        {
            Award[] result = new Award[] { };
            int id;

            if (int.TryParse(departmentID, out id))
            {
                result = m_da.GetDepartmentAwards(id);
            }

            return result;
        }

        public void UpdateRule(Rule rule)
        {
            m_da.UpdateRule(rule);
        }

        public string[] GetUsernames()
        {
            return m_da.GetAllUsernames();
        }

        public User GetUser(string username)
        {
            return new User() { ID=1, Username=username };
        }

        public string[] GetAchievementsTypes()
        {
            return new string[] { "Dinero", "Puntos", "Otros" };
        }

        public AchievementPerUser[] GetUserAchievements(string username)
        {
            return new AchievementPerUser[] { 
                new AchievementPerUser() {Achievement = new Achievement(){Name="Aprendio un nuevo idioma"}, Detail="Portugues"},
                new AchievementPerUser() {Achievement = new Achievement(){Name="Obtuvo licencia de conducir"}, Detail="B1"},
                new AchievementPerUser() {Achievement = new Achievement(){Name="Llego temprano por un mes"}}
            };
        }

        public void AddAchievementToUser(AchievementPerUser achievement, string username)
        {
        }

        public void RemoveAchievementFromUser(AchievementPerUser achievements, string username)
        {
        }

        public Permission[] GetUserPermissions(string username)
        {
            User user = m_da.GetUserByUsername("admin");
            return new Permission[]{ new Permission(){Description=user.Name, Code=user.Username} };
        }

        public Authentication CheckUserAuthentication(string username, string passwordHash)
        {
            return new Authentication() { State=true };
        }

        public Currency[] GetCurrency()
        {
            return new Currency[] {
                new Currency(){ID=1, Name="Dolar", Symbol="$", Code="USD"},
                new Currency(){ID=2, Name="Colón", Symbol="¢", Code="CRC"},
                new Currency(){ID=3, Name="Bitcoin", Symbol="฿", Code="BTC"}
            };
        }

    }
}
