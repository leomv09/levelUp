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
        /// <param name="Content"> The content to send.</param>
        /// <param name="ContentType"> The type of the content.</param>
        /// <returns>The response from the server.</returns>
        /// <example>
        /// <code> 
        /// Send("{"User":{"Name":"Virgilio"}}", "application/json")
        /// </code> 
        /// </example>
        public void Send(string Content, string ContentType)
        {
            //Create a not persistent HttpWebRequest Object from the given URI.
            HttpWebRequest Request = WebRequest.Create(this.uri) as HttpWebRequest;
            Request.KeepAlive = false;
            Request.Method = this.method;

            //Attach the content to the request body.
            byte[] Buffer = Encoding.UTF8.GetBytes(Content);
            Request.ContentLength = Buffer.Length;
            Request.ContentType = ContentType;
            Stream RequestData = Request.GetRequestStream();
            RequestData.Write(Buffer, 0, Buffer.Length);
            RequestData.Close();

            //Get the response from the server.
            HttpWebResponse Response = Request.GetResponse() as HttpWebResponse;
            StreamReader LocalResponseStream = new StreamReader(Response.GetResponseStream());
            this.responseContent = LocalResponseStream.ReadToEnd();
            this.statusCode = Response.StatusCode;

            //Close objects.
            LocalResponseStream.Close();
            Response.Close();
        }

        /// <summary>
        /// Send a empty http request to a server.
        /// </summary>
        /// <returns>The response from the server.</returns>
        public void Send()
        {
            //Create a not persistent HttpWebRequest Object from the given URI.
            HttpWebRequest Request = WebRequest.Create(this.uri) as HttpWebRequest;
            Request.KeepAlive = false;
            Request.Method = this.method;

            //Get the response from the server.
            HttpWebResponse Response = Request.GetResponse() as HttpWebResponse;
            StreamReader LocalResponseStream = new StreamReader(Response.GetResponseStream());
            this.responseContent = LocalResponseStream.ReadToEnd();
            this.statusCode = Response.StatusCode;

            //Close objects.
            LocalResponseStream.Close();
            Response.Close();
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
