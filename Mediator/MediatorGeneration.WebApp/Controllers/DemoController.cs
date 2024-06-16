using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace Bnaya.MediatorSamples;

[ApiController]
[Route("[controller]")]
public class DemoController : ControllerBase
{

    private readonly ILogger<DemoController> _logger;
    private readonly IMediator _mediator;

    public DemoController(
        ILogger<DemoController> logger,
        IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<DemoResponse> PostAsync(DemoRequest request)
    {
        var response = await _mediator.Send(request);
        return response;
    }
}
