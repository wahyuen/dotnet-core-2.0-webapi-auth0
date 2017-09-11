using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace auth0api.Controllers
{
    public abstract class ControllerBase : Controller
    {
        protected IMediator Mediator;

        public ControllerBase(IMediator mediator)
        {
            Mediator = mediator;
        }
    }
}
