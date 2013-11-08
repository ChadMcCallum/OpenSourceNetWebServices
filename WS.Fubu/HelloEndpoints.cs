using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS.Fubu
{
    public class HelloEndpoints
    {
        public Response Get_Hello()
        {
            return new Response() { Say = "Hi there!"};
        }

        public Response Get_Hello_Name(Request request)
        {
            return new Response() {Say = "hi there " + request.Name};
        }
    }

    public class Request
    {
        public string Name { get; set; }
    }



    public class Response
    {
        public string Say { get; set; }
    }
}