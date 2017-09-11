using System.Threading.Tasks;
using auth0api.Login;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace auth0api.Controllers
{
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        public AccountController(IMediator mediator) : base(mediator) { }

        [HttpPost]
        [Route("login")]
        [Authorize]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            await Mediator.Send(request);

            return new NoContentResult();
        }
    }
}
