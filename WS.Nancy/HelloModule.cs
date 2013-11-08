using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace WS.Nancy
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get["/hello"] = x => new { Say = "Hi there"};
            Get["/hello/{Name}"] = x => "Hi there " + x.Name;
        }
    }
}