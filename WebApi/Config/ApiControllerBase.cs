using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Config;

[ApiController]
[Route("api/[controller]")] 
public class ApiControllerBase : ControllerBase
{
    private IMediator _mediator;

    protected IMediator Mediator
    {
        get
        {
            IMediator mediator = _mediator;
            if (mediator == null)
            {
                IMediator? obj = base.HttpContext.RequestServices.GetService<IMediator>() ?? throw new ArgumentNullException("Mediator", "Mediator service not registered");
                IMediator mediator2 = obj;
                _mediator = obj;
                mediator = mediator2;
            }

            return mediator;
        }
    }

    protected async Task<ActionResult<T>> Execute<T>(IRequest<T> request, CancellationToken token)
    {
        return (request == null) ? ((ActionResult<T>)StatusCode(405)) : ((ActionResult<T>)Ok(await Mediator.Send(request, token)));
    }
}
