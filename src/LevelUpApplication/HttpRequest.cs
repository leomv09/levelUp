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
        private string uri;
        private string method;
        private string responseContent;
        private HttpStatusCode statusCode;

        /// <summary>
        /// Initializes a new instance of <see cref="HttpRequest"/> class.
        /// </summary>
        /// <param name="uri">The URI of the resource.</param>
        /// <param name="method">The http method to use (GET, POST, PUT, ...).</param>
        public HttpRequest(string uri, string method)
        {
            this.uri = uri;
            this.method = method;
        }

        /// <summary>
        /// Send a http request to a server.
        /// </summary>
        /// <param name="content"> The content to send.</param>
        /// <param name="contentType"> The type of the content.</param>
        /// <returns>The response from the server.</returns>
        /// <example>
        /// <code> 
        /// Send("{"User":{"Name":"Virgilio"}}", "application/json")
        /// </code> 
        /// </example>
        public void Send(string content, string contentType)
        {
            //Create a not persistent HttpWebRequest Object from the given URI.
            HttpWebRequest request = WebRequest.Create(this.uri) as HttpWebRequest;
            request.KeepAlive = false;
            request.Method = this.method;

            //Attach the content to the request body.
            byte[] buffer = Encoding.UTF8.GetBytes(content);
            request.ContentLength = buffer.Length;
            request.ContentType = contentType;
            Stream requestData = request.GetRequestStream();
            requestData.Write(buffer, 0, buffer.Length);
            requestData.Close();

            //Get the response from the server.
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader localResponseStream = new StreamReader(response.GetResponseStream());
            this.responseContent = localResponseStream.ReadToEnd();
            this.statusCode = response.StatusCode;

            //Close objects.
            localResponseStream.Close();
            response.Close();
        }

        /// <summary>
        /// Send a empty http request to a server.
        /// </summary>
        /// <returns>The response from the server.</returns>
        public void Send()
        {
            //Create a not persistent HttpWebRequest Object from the given URI.
            HttpWebRequest request = WebRequest.Create(this.uri) as HttpWebRequest;
            request.KeepAlive = false;
            request.Method = this.method;

            //Get the response from the server.
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader localResponseStream = new StreamReader(response.GetResponseStream());
            this.responseContent = localResponseStream.ReadToEnd();
            this.statusCode = response.StatusCode;

            //Close objects.
            localResponseStream.Close();
            response.Close();
        }

        public string Uri 
        {
            get { return uri; }
            set { uri = value; }
        }

        public string Method
        {
            get { return method; }
            set { method = value; }
        }

        public string ResponseContent
        {
            get { return responseContent; }
        }

        public HttpStatusCode StatusCode 
        {
            get { return statusCode; }
        }


    }
}
