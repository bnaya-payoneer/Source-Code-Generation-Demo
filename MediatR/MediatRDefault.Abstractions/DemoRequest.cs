using MediatR;

namespace Bnaya.MediatRSamples;

public readonly record struct DemoRequest(
    int Id,
    string ProductName,
    int Amount,
    double Price) : IRequest<DemoResponse>;
