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
            return new Department[] {
                new Department() { ID=1, Name="RRHH"},
                new Department() { ID=2, Name="TI"}
            };
        }

        public Rule[] GetDepartmentRules(string departmentID)
        {
            AchievementPerRule[] exAchievements = new AchievementPerRule[]
            {
                new AchievementPerRule()
                {
                    Achievement = new Achievement(){ ID=3, Name="Llego temprano por un mes", MaxAmount=10} , Amount = 5
                },
                new AchievementPerRule()
                {
                    Achievement = new Achievement(){ ID=1, Name="Aprendio un nuevo idioma", MaxAmount=5} , Amount = 3
                }
            };

            Award[] exAward = new Award[]{
                new Award()
                {
                    ID = 1,
                    Name="Beach Night",
                    Description="Fin de semana en el hotel Barceló playa tambor bajo la modalidad todo incluido para 2 adultos.",
                    Type="Otros",
                    PhotoUrl="img/photos/1/photo.jpg"
                },
                new Award()
                {
                    ID = 2,
                    Name="5 puntos",
                    Type="Puntos",
                    Amount = 5,
                    PhotoUrl="img/photos/2/photo.gif"
                },
                new Award()
                {
                    ID = 3,
                    Name="50 000 colones.",
                    Description="Bono de 50000 colones",
                    Type="Dinero",
                    Money = 50000,
                    Currency = new Currency(){ID=2, Name="Colón", Symbol="¢", Code="CRC"},
                    PhotoUrl="img/photos/3/photo.jpg"
                }
            };

            return new Rule[] { 
                new Rule()
                {
                    Name="ExRule", Description="Description", StartDate="11/09/2013",
                    EndDate="19/10/2013", Achievements=exAchievements, Awards=exAward
                }
            };
        }

        public void AddRuleToDepartment(Rule rule, string departmentID)
        {
        }

        public void DeleteRuleFromDepartment(Rule rule, string departmentID)
        {
        }

        public Achievement[] GetDepartmentAchievements(string departmentID)
        {
            return new Achievement[] {
                new Achievement(){ ID=1, Name="Aprendio un nuevo idioma", MaxAmount=5},
                new Achievement(){ ID=2, Name="Obtuvo licencia de conducir", MaxAmount=1},
                new Achievement(){ ID=3, Name="Llego temprano por un mes", MaxAmount=10}
            };
        }

        public Award[] GetDepartmentAwards(string departmentID)
        {
            return new Award[] {
                new Award()
                {
                    Name="Beach Night",
                    Description="Fin de semana en el hotel Barceló playa tambor bajo la modalidad todo incluido para 2 adultos.",
                    Type="Otros",
                    PhotoUrl="img/photos/1/photo.jpg"
                },
                new Award()
                {
                    Name="5 puntos",
                    Type="Puntos",
                    Amount = 5,
                    PhotoUrl="img/photos/2/photo.gif"
                },
                new Award()
                {
                    Name="50 000 colones.",
                    Description="Bono de 50000 colones",
                    Type="Dinero",
                    Money = 50000,
                    Currency = new Currency(){ID=2, Name="Colón", Symbol="¢", Code="CRC"},
                    PhotoUrl="img/photos/3/photo.jpg"
                }
            };
        }

        public void UpdateRule(Rule rule)
        {
        }

        public User[] GetUsers()
        {
            return new User[] {
                new User(){ Username="jags9415" },
                new User(){ Username="leomv09" },
                new User(){ Username="emurillo" },
                new User(){ Username="dhf360" }
            };
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
            return null;
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
