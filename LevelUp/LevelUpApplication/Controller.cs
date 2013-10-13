using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelUpApplication
{
    class Controller
    {
        /// <summary>
        /// Get the name of all departments in the organization.
        /// </summary>
        public string[] GetDepartments() 
        {
            return new string[] { "IC", "TI" };
        }

        /// <summary>
        /// Get all the rules asociated with a department.
        /// </summary>
        /// <param name="Department">The name of the department</param>
        public string[][] GetRules(string Department) 
        {
            return new string[][] { 
                new string[] {"Rule1", "Rule1 Description", "10/08/2013", "12/09/2013"},
                new string[] {"Rule2", "Rule2 Description", "22/06/2013", "11/10/2013"}
            };
        }

        public void AddRule() { }
        public void ModifyRule() { }
        public void RemoveRule() { }

        /// <summary>
        /// Gets the username of all users in the database.
        /// </summary>
        public string[] GetUsers()
        {
            return new string[] { 
                            "jags9415",
                            "leomv09",
                            "emurillo",
                            "dhf360"
            };
        }

        public void GetUser() { }

        /// <summary>
        /// Gets the achievements of a user.
        /// </summary>
        /// <param name="Username">The username of the user.</param>
        public string[][] GetAchievements(string Username) 
        { 
            return new string[][] { 
                new string[] {"Achievement1", "Type", "7"},
                new string[] {"Achievement2", "Type", "6"},
                new string[] {"Achievement3", "Type", "10"}
            };        
        }

        public void AddAchievement() { }

    }
}
