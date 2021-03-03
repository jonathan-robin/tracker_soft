using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace TestingReactDotNet.Controllers
{
    [System.Web.Http.Route(":3000/api/test")]
    public class DisplayNameController : Controller
    {
        [System.Web.Http.HttpPost, System.Web.Http.Route("Greeting")]
        public string Greeting(string name)
        {
            var greeting = "Hello" + name;
            return greeting;
        }
    }
}

