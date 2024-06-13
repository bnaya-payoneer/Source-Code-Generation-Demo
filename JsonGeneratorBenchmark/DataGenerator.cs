namespace Bnaya.Samples;

internal static class DataGenerator
{
    private static readonly string[] FirstNames = new[]
    {
        "Steffan", "Garin", "Fahad", "Eliana", "Thea", "Edmund", "Layla", "Tony", "Zakir", "Ariyah"
    };

    private static readonly string[] LastNames = new[]
    {
        "English", "Holder", "Beech", "Simon", "Briggs", "Terry", "Horton", "Leblanc", "Rodriguez", "Atkins"
    };

    public static Person1 GetPerson() => GetPeople(1)[0];

    public static Person1[] GetPeople(int num)
    {
        Random rng = new();

        return Enumerable.Range(1, num).Select(indexer => new Person1()
        {
            FirstName = FirstNames[rng.Next(FirstNames.Length)],
            LastName = LastNames[rng.Next(LastNames.Length)]
        }).ToArray();
    }
}
