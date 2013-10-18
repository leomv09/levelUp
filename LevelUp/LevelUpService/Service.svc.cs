using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel.Activation;

namespace LevelUpService
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service : IService
    {

        public Department[] GetDepartments()
        {
            return new Department[]{
                new Department(){ Name = "RRHH" },
                new Department(){ Name = "TI" }
            };
        }

        public Rule[] GetDepartmentRules(string departmentID)
        {
            return null;
        }

        public void AddRuleToDepartment(Rule rule, string departmentID)
        {
        }

        public Achievement[] GetDepartmentAchievements(string departmentID)
        {
            return null;
        }

        public Award[] GetDepartmentAwards(string departmentID)
        {
            return null;
        }

        public void UpdateRule(Rule rule)
        {
        }

        public void DeleteRule(Rule rule)
        {
        }

        public string[] GetAchievementsTypes()
        {
            return null;
        }

        public User[] GetUsers()
        {
            return null;
        }

        public Achievement[] GetUserAchievements(string username)
        {
            return null;
        }

        public void AddAchievementToUser(Achievement achievement, string username)
        {
        }

        public void DeleteAchievementFromUser(Achievement achievement, string username)
        {
        }

        public Permission[] GetUserPermissions()
        {
            return null;
        }

        public Currency[] GetCurrency()
        {
            return null;
        }

    }
}
