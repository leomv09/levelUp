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
        /// </summary>
        /// <param name="Department"> The Uri of the resource to request.</param>
        /// <returns></returns>
        public string[][] GetRules(string Department) 
        {
            return new string[][] { 
                new string[] {"Rule1", "Rule1 Description", "10/08/2013", "12/09/2013"},
                new string[] {"Rule2", "Rule2 Description", "22/06/2013", "11/10/2013"}
            };
        }

        void AddRule() { }
        void ModifyRule() { }
        void RemoveRule() { }
        void GetUsers() { }
        void GetUser() { }
        void GetAchievements() { }
        void AddAchievement() { }

    }
}
