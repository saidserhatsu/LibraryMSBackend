using MediatR;
using Microsoft.AspNetCore.Mvc;
using NArchitecture.Core.Security.Extensions;

namespace WebAPI.Controllers;

public class BaseController : ControllerBase
{
    protected IMediator Mediator =>
        _mediator ??=
            HttpContext.RequestServices.GetService<IMediator>()
            ?? throw new InvalidOperationException("IMediator cannot be retrieved from request services.");

    private IMediator? _mediator;

    protected string getIpAddress()
    {
        string ipAddress = Request.Headers.ContainsKey("X-Forwarded-For")
            ? Request.Headers["X-Forwarded-For"].ToString()
            : HttpContext.Connection.RemoteIpAddress?.MapToIPv4().ToString()
                ?? throw new InvalidOperationException("IP address cannot be retrieved from request.");
        return ipAddress;
    }

    protected Guid getUserIdFromRequest() //todo authentication behavior?
    {
        // Access token my be not valid or expired so we need to handle this case

        if (!HttpContext.User.Identity?.IsAuthenticated ?? true)
        {
            throw new InvalidOperationException("User is not authenticated.");
        }
        var userId = Guid.Parse(HttpContext.User.GetUserId().ToString()!);
        return userId;
    }
}
