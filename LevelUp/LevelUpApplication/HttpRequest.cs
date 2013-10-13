using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace LevelUpApplication
{
    class HttpRequest
    {
        /// <summary>
        /// Send a http request to a server.
        /// </summary>
        /// <param name="Uri"> The Uri of the resource to request.</param>
        /// <param name="Method"> The http verb to use.</param>
        /// <param name="Content"> The content to send.</param>
        /// <param name="ContentType"> The type of the content.</param>
        /// <returns>The response from the server</returns>
        /// <example>
        /// <code> 
        /// Send("localhost/users/", "POST", "<Users><Name>Jose</Name></Users>", "application/xml")
        /// </code> 
        /// </example>
        public static string Send(string Uri, string Method, string Content, string ContentType)
        {
            //Create a not persistent HttpWebRequest Object from the given URI.
            HttpWebRequest Request = WebRequest.Create(Uri) as HttpWebRequest;
            Request.KeepAlive = false;
            Request.Method = Method;

            //Attach the content to the request body.
            byte[] Buffer = Encoding.UTF8.GetBytes(Content);
            Request.ContentLength = Buffer.Length;
            Request.ContentType = ContentType;
            Stream requestData = Request.GetRequestStream();
            requestData.Write(Buffer, 0, Buffer.Length);
            requestData.Close();

            //Get the response from the server.
            HttpWebResponse Response = Request.GetResponse() as HttpWebResponse;
            StreamReader LocalResponseStream = new StreamReader(Response.GetResponseStream());
            string ResponseContent = LocalResponseStream.ReadToEnd();
            LocalResponseStream.Close();
            Response.Close();

            return ResponseContent;
        }

        /// <summary>
        /// Request information to a server.
        /// </summary>
        /// <param name="Uri"> The Uri of the resource to get.</param>
        /// <returns>The response from the server</returns>
        /// <example>  
        /// <code> 
        /// Get("localhost/users/102")
        /// </code> 
        /// </example>
        public static string Get(string Uri)
        {
            //Create a not persistent HttpWebRequest Object from the given URI.
            HttpWebRequest Request = WebRequest.Create(Uri) as HttpWebRequest;
            Request.KeepAlive = false;
            Request.Method = "GET";

            //Get the response from the server.
            HttpWebResponse Response = Request.GetResponse() as HttpWebResponse;
            StreamReader LocalResponseStream = new StreamReader(Response.GetResponseStream());
            string ResponseContent = LocalResponseStream.ReadToEnd();
            LocalResponseStream.Close();
            Response.Close();

            return ResponseContent;
        }

    }
}
