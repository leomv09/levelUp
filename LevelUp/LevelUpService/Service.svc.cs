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

        public Rule AddRuleToDepartment(Rule rule, string departmentID)
        {
            int id;

            if (int.TryParse(departmentID, out id))
            {
                if (rule.ID == 0)
                {
                    rule.ID = m_da.CreateRule(rule);
                }
                m_da.AddRuleToDepartment(rule.ID, id);
            }

            return rule;
        }

        public void DeleteRuleFromDepartment(Rule rule, string departmentID)
        {
            int id;

            if (int.TryParse(departmentID, out id))
            {
                m_da.DeleteRuleFromDepartment(rule.ID, id);
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
            return m_da.GetUserByUsername(username);
        }

        public string[] GetAwardsTypes()
        {
            return m_da.GetAwardTypes();
        }

        public AchievementPerUser[] GetUserAchievements(string username)
        {
            return m_da.GetUserAchievements(username);
        }

        public void AddAchievementToUser(AchievementPerUser achievement, string username)
        {
            m_da.AddAchievementToUser(achievement, username);
        }

        public void RemoveAchievementFromUser(AchievementPerUser achievement, string username)
        {
            m_da.RemoveAchievementFromUser(achievement, username);
        }

        public Permission[] GetUserPermissions(string username)
        {
            return m_da.GetUserPermissions(username);
        }

        public Authentication CheckUserAuthentication(string username, string passwordHash)
        {
            Authentication auth = new Authentication();
            if (m_da.CheckAuthentication(username, passwordHash))
            {
                auth.State = true;
                auth.User = m_da.GetUserByUsername(username);
            }
            return auth;
        }

        public Currency[] GetCurrency()
        {
            return m_da.GetAllCurrency();
        }

    }
}
