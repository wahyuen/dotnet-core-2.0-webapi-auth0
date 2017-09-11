using Microsoft.AspNetCore.Mvc;

namespace auth0api.Controllers
{
    [Route("silent")]
    public class SilentController : Controller
    {
        [HttpGet]
        public IActionResult Silent()
        {
            return File("~silent/silent.html", "text/html");
        }
    }
}
