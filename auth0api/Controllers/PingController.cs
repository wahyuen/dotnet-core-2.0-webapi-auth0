using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace auth0api.Controllers
{
    [Route("api")]
    public class PingController : Controller
    {
        [HttpGet]
        [Route("ping")]
        public JsonResult Ping()
        {
            return new JsonResult("Pong");
        }

        [Authorize]
        [HttpGet]
        [Route("ping/secure")]
        public JsonResult PingSecured()
        {
            return new JsonResult("All good. You only get this message if you are authenticated.");
        }
    }
}