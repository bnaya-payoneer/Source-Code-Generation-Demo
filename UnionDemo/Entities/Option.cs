using Dunet;

namespace Bnaya.Samples;

[Union]
partial record Option<T>
{
    partial record Some(T Value);
    partial record None();
}