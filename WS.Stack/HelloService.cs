using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace WS.Stack
{
	public class HelloService : Service
	{
        public Response Get(Request request)
        {
            if(string.IsNullOrEmpty(request.Name))
            return new Response() {Say = "hi there"};

            return new Response() { Say = "hi there "  + request.Name};
        }
	}

    [Route("/hello")]
    [Route("/hello/{Name}")]
    public class Request
    {
        public string Name { get; set; }
    }



    public class Response
    {
        public string Say { get; set; }
    }
}