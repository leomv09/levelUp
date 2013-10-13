using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace LevelUpApplication
{
    class JSONSerializer
    {
        /// <summary>
        /// Serializes an object to a JSON string.
        /// </summary>
        /// <typeparam name="T">The type of the object to serialize.</typeparam>
        /// <param name="Obj">The object to serialize.</param>
        /// <returns>The JSON string.</returns>
        public static string Serialize<T>(T Obj)
        {
            DataContractJsonSerializer Serializer = new DataContractJsonSerializer(typeof(T));
            MemoryStream MStream = new MemoryStream();
            Serializer.WriteObject(MStream, Obj);
            string JSONString = Encoding.UTF8.GetString(MStream.ToArray());
            MStream.Close();
            return JSONString;
        }

        /// <summary>
        /// Deserializes a JSON string.
        /// </summary>
        /// <typeparam name="T">The type of the deserialized object.</typeparam>
        /// <param name="JSONString">The JSON string.</param>
        /// <returns>The deserialized object.</returns>
        public static T Deserialize<T>(string JSONString)
        {
            DataContractJsonSerializer Serializer = new DataContractJsonSerializer(typeof(T));
            MemoryStream MStream = new MemoryStream(Encoding.UTF8.GetBytes(JSONString));
            T Obj = (T)Serializer.ReadObject(MStream);
            return Obj;
        }
    }
}
