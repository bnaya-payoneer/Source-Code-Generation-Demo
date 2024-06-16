using Dunet;

namespace Bnaya.Samples;

[Union]
public partial record Result<T>
{
    partial record Success(T Value);
    partial record Failure(Exception Error);
}
