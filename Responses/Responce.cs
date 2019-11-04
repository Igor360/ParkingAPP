using System;
using MySqlX.XDevAPI;

namespace WebApplication1.Responses
{
    [Serializable]
    public class Response<T> 
    {
        public string status { get; set; }
        
        public string message { get; set; }

        public Collection<T> data { get; set; }

        public Response(string status)
        {
            this.status = status;
        }

        public Response(string status, string message)
        {
            this.status = status;
            this.message = message;
        }

        public Response(string status, string message, Collection<T> data)
        {
            this.status = status;
            this.message = message;
            this.data = data;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}