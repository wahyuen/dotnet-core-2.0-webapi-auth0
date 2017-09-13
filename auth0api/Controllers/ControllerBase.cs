using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace auth0api.Controllers
{
    public abstract class ControllerBase : Controller
    {
        protected IMediator Mediator;

        protected ControllerBase(IMediator mediator)
        {
            Mediator = mediator;
        }
    }
}
