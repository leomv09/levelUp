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
            return new Rule[]{
                new Rule {Name="ExRule", StartDate="11/09/2013"}
            };
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
            return new User[]{
                new User(){ Username="jags9415" },
                new User(){ Username="leomv09" },
                new User(){ Username="emurillo" },
                new User(){ Username="dhf360" }
            };
        }

        public AchievementPerUser[] GetUserAchievements(string username)
        {
            return new AchievementPerUser[] { 
                new AchievementPerUser() {Achievement = new Achievement(){Name="Aprendio un nuevo idioma"}, Detail="Portugues"},
                new AchievementPerUser() {Achievement = new Achievement(){Name="Obtuvo licencia de conducir"}, Detail="B1"},
                new AchievementPerUser() {Achievement = new Achievement(){Name="Llego temprano por un mes"}}
            };
        }

        public void AddAchievementToUser(Achievement achievement, string username)
        {
        }

        public void DeleteAchievementFromUser(Achievement achievement, string username)
        {
        }

        public Permission[] GetUserPermissions(string username)
        {
            return null;
        }

        public Authentication CheckUserAuthentication(string username, string passwordHash)
        {
            return null;
        }

        public Currency[] GetCurrency()
        {
            return new Currency[]{
                new Currency(){Name="Dolar"},
                new Currency(){Name="Colon"},
                new Currency(){Name="Bitcoin"},
            };
        }

    }
}
