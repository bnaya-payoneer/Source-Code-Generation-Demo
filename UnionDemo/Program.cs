using Bnaya.Samples;


Result<double> Divide(double numerator, double denominator)
{
    if (denominator is 0d)
    {
        return new InvalidOperationException("Cannot divide by zero!");
    }
    return numerator / denominator;
}

var result = Divide(50, 0);
var output = result.Match(
    success => success.Value.ToString(),
    failure => failure.Error.Message
);

Console.WriteLine($"Reuslt = {output}");

// --------------------------------------------------------

var shape = new Shape.Rectangle(3, 4);
var area = shape.Match(
    circle => 3.14 * circle.Radius * circle.Radius,
    rectangle => rectangle.Length * rectangle.Width,
    triangle => triangle.Base * triangle.Height / 2
);
Console.WriteLine($"Area: { area}");

// --------------------------------------------------------

