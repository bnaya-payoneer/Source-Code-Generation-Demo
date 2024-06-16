using Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnaya.MediatorSamples;

public class DemoHandler : IRequestHandler<DemoRequest, DemoResponse>
{
    private readonly IMediator _mediator;
    private readonly TimeProvider _timeProvider;

    public DemoHandler(
        IMediator mediator,
        TimeProvider? timeProvider = null)
    {
        _mediator = mediator;
        _timeProvider = timeProvider ?? TimeProvider.System;
    }

    public async ValueTask<DemoResponse> Handle(
                    DemoRequest request, 
                    CancellationToken cancellationToken)
    {
        await Task.Yield(); 
        var e = new DemoResponse(request.Id, _timeProvider.GetUtcNow());
        return e;
    }
}

