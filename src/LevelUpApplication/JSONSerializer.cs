using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace LevelUp.Logic
{
    class JSONSerializer
    {
        /// <summary>
        /// Serializes an object to a JSON string.
        /// </summary>
        /// <typeparam name="T">The type of the object to serialize.</typeparam>
        /// <param name="obj">The object to serialize.</param>
        /// <returns>The JSON string.</returns>
        public string Serialize<T>(T obj)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            MemoryStream memoryStream = new MemoryStream();
            serializer.WriteObject(memoryStream, obj);
            string jsonString = Encoding.UTF8.GetString(memoryStream.ToArray());
            memoryStream.Close();
            return jsonString;
        }

        /// <summary>
        /// Deserializes a JSON string.
        /// </summary>
        /// <typeparam name="T">The type of the deserialized object.</typeparam>
        /// <param name="jsonString">The JSON string.</param>
        /// <returns>The deserialized object.</returns>
        public T Deserialize<T>(string jsonString)
        {
            T obj = default(T);
            if (!String.IsNullOrEmpty(jsonString))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
                obj = (T) serializer.ReadObject(memoryStream);
            }
            return obj;
        }
    }
}
