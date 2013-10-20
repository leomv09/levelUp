using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using LevelUpService;

namespace LevelUpApplication
{
    class Controller
    {
        private static Controller instance;
        private JSONSerializer serializer;

        private Controller()
        {
            this.serializer = new JSONSerializer();
        }

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
        /// Get the name of all departments of the organization.
        /// </summary>
        public Department[] GetDepartments()
        {
            HttpRequest request = new HttpRequest("https://localhost/levelup/departments", "GET");
            Department[] departments = new Department[]{};
            request.Send();

            if (request.StatusCode == HttpStatusCode.OK)
            {
                departments = serializer.Deserialize<Department[]>(request.ResponseContent);
            }

            return departments;
        }

        /// <summary>
        /// Get all the rules asociated with a department.
        /// </summary>
        /// <param name="departmentName">The name of the department</param>
        public Rule[] GetDepartmentRules(Department department)
        {
            HttpRequest request = new HttpRequest(
                "https://localhost/levelup/departments/" + department.ID +"/rules", "GET");
            Rule[] rules = new Rule[] { };
            request.Send();

            if (request.StatusCode == HttpStatusCode.OK)
            {
                rules = serializer.Deserialize<Rule[]>(request.ResponseContent);
            }

            return rules;
        }

        public bool AddRuleToDepartment(Rule rule, Department department) 
        {
            HttpRequest request = new HttpRequest(
                    "https://localhost/levelup/departments/" + department.ID + "/rules", "POST");
            string content = serializer.Serialize<Rule>(rule);
            request.Send(content, Constants.JASON_MIMEType);
            return request.StatusCode == HttpStatusCode.OK;
        }

        public bool RemoveRuleFromDepartment(Rule rule, Department department)
        {
            HttpRequest request = new HttpRequest(
                        "https://localhost/levelup/departments/" + department.ID + "/rules", "DELETE");
            string content = serializer.Serialize<Rule>(rule);
            request.Send(content, Constants.JASON_MIMEType);
            return request.StatusCode == HttpStatusCode.OK;
        }

        public bool ModifyRule(Rule rule)
        {
            HttpRequest request = new HttpRequest(
                        "https://localhost/levelup/rules", "PUT");
            string content = serializer.Serialize<Rule>(rule);
            request.Send(content, Constants.JASON_MIMEType);
            return request.StatusCode == HttpStatusCode.OK;
        }

        /// <summary>
        /// Gets all users in the database.
        /// </summary>
        public User[] GetUsers()
        {
            HttpRequest request = new HttpRequest("https://localhost/levelup/users", "GET");
            User[] users = new User[] { };
            request.Send();

            if (request.StatusCode == HttpStatusCode.OK)
            {
                users = serializer.Deserialize<User[]>(request.ResponseContent);
            }

            return users;
        }

        public User GetUser(string username)
        {
            HttpRequest request = new HttpRequest("https://localhost/levelup/users/" + username, "GET");
            User user = new User();
            request.Send();

            if (request.StatusCode == HttpStatusCode.OK)
            {
                user = serializer.Deserialize<User>(request.ResponseContent);
            }

            return user;
        }

        /// <summary>
        /// Gets all the achievements types.
        /// </summary>
        public string[] GetAchievementsTypes()
        {
            HttpRequest request = new HttpRequest("https://localhost/levelup/achievements/types", "GET");
            string[] types = new string[] { };
            request.Send();

            if (request.StatusCode == HttpStatusCode.OK)
            {
                types = serializer.Deserialize<string[]>(request.ResponseContent);
            }

            return types;
        }

        /// <summary>
        /// Gets the achievements of a user.
        /// </summary>
        /// <param name="user">The user.</param>
        public AchievementPerUser[] GetUserAchievements(User user) 
        {
            HttpRequest request = new HttpRequest(
                "https://localhost/levelup/users/" + user.Username + "/achievements", "GET");
            AchievementPerUser[] achievements = new AchievementPerUser[] { };
            request.Send();

            if (request.StatusCode == HttpStatusCode.OK)
            {
                achievements = serializer.Deserialize<AchievementPerUser[]>(request.ResponseContent);
            }

            return achievements;
        }

        /// <summary>
        /// Gets all the achievements asociated with a department.
        /// </summary>
        /// <param name="department">The department.</param>
        public Achievement[] GetDepartmentAchievements(Department department)
        {
            HttpRequest request = new HttpRequest(
                "https://localhost/levelup/departments/" + department.ID + "/achievements", "GET");
            Achievement[] achievements = new Achievement[] { };
            request.Send();

            if (request.StatusCode == HttpStatusCode.OK)
            {
                achievements = serializer.Deserialize<Achievement[]>(request.ResponseContent);
            }

            return achievements;
        }

        /// <summary>
        /// Gets all the awards asociated with a department.
        /// </summary>
        /// <param name="Department">The department.</param>
        /// <returns></returns>
        public Award[] GetDepartmentAwards(Department department)
        {
            HttpRequest request = new HttpRequest(
                "https://localhost/levelup/departments/" + department.ID + "/awards", "GET");
            Award[] awards = new Award[] { };
            request.Send();

            if (request.StatusCode == HttpStatusCode.OK)
            {
                awards = serializer.Deserialize<Award[]>(request.ResponseContent);
            }

            return awards;
        }

        public bool RemoveAchievementFromUser(User user, AchievementPerUser achievement)
        {
            HttpRequest request = new HttpRequest(
                        "https://localhost/levelup/users/" + user.ID + "/achievements", "DELETE");
            string content = serializer.Serialize<AchievementPerUser>(achievement);
            request.Send(content, Constants.JASON_MIMEType);
            return request.StatusCode == HttpStatusCode.OK;
        }

        public bool UpdateUserAchievements(User user, AchievementPerUser[] achievement)
        {
            HttpRequest request = new HttpRequest(
                        "https://localhost/levelup/users/" + user.ID + "/achievements", "PUT");
            string content = serializer.Serialize<AchievementPerUser[]>(achievement);
            request.Send(content, Constants.JASON_MIMEType);
            return request.StatusCode == HttpStatusCode.OK;
        }

        /// <summary>
        /// Gets the name of all the currency of the system.
        /// </summary>
        public Currency[] GetCurrency()
        {
            HttpRequest request = new HttpRequest("https://localhost/levelup/currency", "GET");
            Currency[] currency = new Currency[] { };
            request.Send();

            if (request.StatusCode == HttpStatusCode.OK)
            {
                currency = serializer.Deserialize<Currency[]>(request.ResponseContent);
            }

            return currency;
        }

        public Permission[] GetUserPermissions(User user)
        {
            HttpRequest request = new HttpRequest(
                "https://localhost/levelup/users/" + user.Username + "/permissions", "GET");
            Permission[] permissions = new Permission[] { };
            request.Send();

            if (request.StatusCode == HttpStatusCode.OK)
            {
                permissions = serializer.Deserialize<Permission[]>(request.ResponseContent);
            }

            return permissions;
        }

        public Authentication GetUserAuthentication(string username, string passwordHash)
        {
            HttpRequest request = new HttpRequest(
                "https://localhost/levelup/users/" + username + "/authentication?p=" + passwordHash, "GET");
            Authentication authentication = new Authentication();
            request.Send();

            if (request.StatusCode == HttpStatusCode.OK)
            {
                authentication = serializer.Deserialize<Authentication>(request.ResponseContent);
            }

            return authentication;
        }

    }
}
