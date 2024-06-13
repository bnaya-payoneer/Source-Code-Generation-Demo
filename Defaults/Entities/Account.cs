using Generator.Equals;

namespace Bnaya.Samples;

[Equatable]
public readonly partial record struct Account(AccountId Id)
{
    #region public static Account Default { get;  } = ...

    public static Account Default { get; } = new Account((AccountId)10)
    {
        Holder = Person.Default
    };

    #endregion //  public static Account Default { get;  } = ...

    public required Person Holder { get; init; }
}
