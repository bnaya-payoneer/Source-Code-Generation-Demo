using Bnaya.Samples;

var builder = Person.CreateBuilder()
    .AddId(1)
    .AddName("Bnaya")
    .AddEmail("bnaya@work.com");

var person = builder.Build();
Console.WriteLine(person);


