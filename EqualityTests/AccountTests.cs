namespace Bnaya.Samples;

public class AccountTests
{
    [Fact]
    public void AccountEquality_Test()
    {
        Account a = Account.Default;
        Account b = Account.Default;

        Assert.Equal(a, b);
    }
}