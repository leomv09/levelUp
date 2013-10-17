using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelUpApplication
{
    class Controller
    {
        private static Controller instance;

        private Controller() {}

        /// <summary>
        /// Gets the singleton instance of the class.
        /// </summary>
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        /// <summary>
        /// Get the name of all departments in the organization.
        /// </summary>
        public string[] GetDepartmentsName()
        {
            return new string[] { "IC", "TI" };
        }

        /// <summary>
        /// Get all the rules asociated with a department.
        /// </summary>
        /// <param name="Department">The name of the department</param>
        public string[][] GetDepartmentRules(string Department) 
        {
            return new string[][] { 
                new string[] {"Rule1", "Rule1 Description", "10/08/2013", "12/09/2013"},
                new string[] {"Rule2", "Rule2 Description", "22/06/2013", "11/10/2013"}
            };
        }

        public void AddRuleToDepartment() { }
        public void ModifyRule() { }
        public void RemoveRule() { }

        /// <summary>
        /// Gets the username of all users in the database.
        /// </summary>
        public string[] GetUsernames()
        {
            return new string[] { 
                "jags9415",
                "leomv09",
                "emurillo",
                "dhf360"
            };
        }

        /// <summary>
        /// Gets all the achievements types.
        /// </summary>
        public string[] GetAchievementsTypes()
        {
            return new string[] { "Dinero", "Puntos", "Otros" };
        }

        /// <summary>
        /// Gets the achievements of a user.
        /// </summary>
        /// <param name="Username">The username of the user.</param>
        public string[][] GetUserAchievements(string Username) 
        { 
            return new string[][] { 
                new string[] {"Aprendio un nuevo idioma", "Portugues", "13/08/2013", "admin"},
                new string[] {"Obtuvo licencia de conducir", "B1", "21/02/2013", "admin"},
                new string[] {"Llego temprano por un mes", "", "03/10/2013", "admin"}
            };        
        }

        /// <summary>
        /// Gets all the achievements asociated with a department.
        /// </summary>
        /// <param name="Department">The name of the department.</param>
        public string[] GetDepartmentAchievements(string Department)
        {
            return new string[] {
                "Aprendio un nuevo idioma",
                "Obtuvo licencia de conducir",
                "Llego temprano por un mes"
            };
        }

        public void AddAchievementToUser(string Username) { }
        public void RemoveAchievementFromUser(string Username) { }
        public void AddAchievementToDepartment(string Department) { }

        /// <summary>
        /// Gets all the awards asociated with a department.
        /// </summary>
        /// <param name="Department">The name of the department.</param>
        /// <returns></returns>
        public string[] GetDepartmentAwards(string Department)
        {
            return new string[] {
                "5 Puntos",
                "Beach Night",
                "Dia Libre"
            };
        }

        /// <summary>
        /// Gets the name of all the currency od the system.
        /// </summary>
        public string[] GetCurrencyNames()
        {
            return new string[] {
                "Dolar",
                "Colon",
                "Bitcoin"
            };
        }

    }
}
