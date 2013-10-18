using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LevelUpService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/departments",
                BodyStyle = WebMessageBodyStyle.Bare,
                ResponseFormat = WebMessageFormat.Json)]
        Department[] GetDepartments();

        [OperationContract]
        [WebGet(UriTemplate = "/departments/{departmentID}/rules",
                BodyStyle = WebMessageBodyStyle.Bare,
                ResponseFormat = WebMessageFormat.Json)]
        Rule[] GetDepartmentRules(string departmentID);

        [OperationContract(IsOneWay = true)]
        [WebInvoke(UriTemplate = "/departments/{departmentID}/rules",
                Method = "POST",
                BodyStyle = WebMessageBodyStyle.Bare,
                RequestFormat = WebMessageFormat.Json)]
        void AddRuleToDepartment(Rule rule, string departmentID);

        [OperationContract]
        [WebGet(UriTemplate = "/departments/{departmentID}/achievements",
                BodyStyle = WebMessageBodyStyle.Bare,
                ResponseFormat = WebMessageFormat.Json)]
        Achievement[] GetDepartmentAchievements(string departmentID);

        [OperationContract]
        [WebGet(UriTemplate = "/departments/{departmentID}/awards",
                BodyStyle = WebMessageBodyStyle.Bare,
                ResponseFormat = WebMessageFormat.Json)]
        Award[] GetDepartmentAwards(string departmentID);

        [OperationContract(IsOneWay = true)]
        [WebInvoke(UriTemplate = "/rules",
                Method = "PUT",
                BodyStyle = WebMessageBodyStyle.Bare,
                RequestFormat = WebMessageFormat.Json)]
        void UpdateRule(Rule rule);

        [OperationContract(IsOneWay = true)]
        [WebInvoke(UriTemplate = "/rules",
                Method = "DELETE",
                BodyStyle = WebMessageBodyStyle.Bare,
                RequestFormat = WebMessageFormat.Json)]
        void DeleteRule(Rule rule);

        [OperationContract]
        [WebGet(UriTemplate = "/achievements/types",
                BodyStyle = WebMessageBodyStyle.Bare,
                ResponseFormat = WebMessageFormat.Json)]
        string[] GetAchievementsTypes();

        [OperationContract]
        [WebGet(UriTemplate = "/users",
                BodyStyle = WebMessageBodyStyle.Bare,
                ResponseFormat = WebMessageFormat.Json)]
        User[] GetUsers();

        [OperationContract]
        [WebGet(UriTemplate = "/users/{username}/achievements",
                BodyStyle = WebMessageBodyStyle.Bare,
                ResponseFormat = WebMessageFormat.Json)]
        AchievementPerUser[] GetUserAchievements(string username);

        [OperationContract(IsOneWay = true)]
        [WebInvoke(UriTemplate = "/users/{username}/achievements",
                Method = "POST",
                BodyStyle = WebMessageBodyStyle.Bare,
                RequestFormat = WebMessageFormat.Json)]
        void AddAchievementToUser(Achievement achievement, string username);

        [OperationContract(IsOneWay = true)]
        [WebInvoke(UriTemplate = "/users/{username}/achievements",
                Method = "DELETE",
                BodyStyle = WebMessageBodyStyle.Bare,
                RequestFormat = WebMessageFormat.Json)]
        void DeleteAchievementFromUser(Achievement achievement, string username);

        [OperationContract]
        [WebGet(UriTemplate = "/users/{username}/permissions",
                BodyStyle = WebMessageBodyStyle.Bare,
                ResponseFormat = WebMessageFormat.Json)]
        Permission[] GetUserPermissions(string username);

        [OperationContract]
        [WebGet(UriTemplate = "/users/{username}/authentication?p={passwordHash}",
                BodyStyle = WebMessageBodyStyle.Bare,
                ResponseFormat = WebMessageFormat.Json)]
        Authentication CheckUserAuthentication(string username, string passwordHash);

        [OperationContract]
        [WebGet(UriTemplate = "/currency",
                BodyStyle = WebMessageBodyStyle.Bare,
                ResponseFormat = WebMessageFormat.Json)]
        Currency[] GetCurrency();
    }
}
