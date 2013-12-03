using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Api
{
    public class TestController : ApiController
    {
        // GET api/<controller>
        public TestModel GetObject()
        {
            return new TestModel();
        }

    }
}