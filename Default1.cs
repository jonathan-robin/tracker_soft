namespace TestingReactDotNet.Controllers
{
    [Route("api/[controller]")]
    public class DisplayNameController : Controller
    {
        [HttpGet, Route("Greeting")]
        public string Greeting(string name)
        {
            var greeting = "Hello" + name;
            return greeting;
        }
    }
}
