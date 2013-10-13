using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

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
        /// <param name="Department"></param>
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

        /// <summary>
        /// Serializes an object to a Json string.
        /// </summary>
        /// <typeparam name="T">The type of the object to serialize.</typeparam>
        /// <param name="Obj">The object to serialize.</param>
        /// <returns>The Json string.</returns>
        private string SerializeJson<T>(T Obj)
        {
            DataContractJsonSerializer Serializer = new DataContractJsonSerializer( typeof(T) );
            MemoryStream MStream = new MemoryStream();
            Serializer.WriteObject(MStream, Obj);
            string JsonString = Encoding.UTF8.GetString( MStream.ToArray() );
            MStream.Close();
            return JsonString;
        }

        /// <summary>
        /// Deserializes a Json string.
        /// </summary>
        /// <typeparam name="T">The type of the deserialized object.</typeparam>
        /// <param name="JsonString">The Json string.</param>
        /// <returns>The deserialized object.</returns>
        private T DeserializeJson<T>(string JsonString)
        {
            DataContractJsonSerializer Serializer = new DataContractJsonSerializer( typeof(T) );
            MemoryStream MStream = new MemoryStream( Encoding.UTF8.GetBytes(JsonString) );
            T Obj = (T) Serializer.ReadObject(MStream);
            return Obj;
        }

    }
}
