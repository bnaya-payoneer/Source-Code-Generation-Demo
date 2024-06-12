// Ignore Spelling: Vogen

namespace Bnaya.Samples;

public class GuardsTests
{
    [Fact]
    public void ErrorsTest()
    {
        // catches object creation expressions
        //var c = new AccountId(); // error VOG010: Type 'AccountId' cannot be constructed with 'new' as it is prohibited
        //AccountId c = default; // error VOG009: Type 'AccountId' cannot be constructed with default as it is prohibited.

        //var c = default(AccountId); // error VOG009: Type 'AccountId' cannot be constructed with default as it is prohibited.
        //var c = GetAccountId(); // error VOG010: Type 'AccountId' cannot be constructed with 'new' as it is prohibited

        //var c = Activator.CreateInstance<AccountId>(); // error VOG025: Type 'AccountId' cannot be constructed via Reflection as it is prohibited.
        //var c = Activator.CreateInstance(typeof(AccountId)); // error VOG025: Type 'MyVo' cannot be constructed via Reflection as it is prohibited

        // catches lambda expressions
        //Func<AccountId> f = () => default; // error VOG009: Type 'AccountId' cannot be constructed with default as it is prohibited.

        // catches method / local function return expressions
        //AccountId GetAccountId() => default; // error VOG009: Type 'AccountId' cannot be constructed with default as it is prohibited.
        //AccountId GetAccountId() => new AccountId(); // error VOG010: Type 'AccountId' cannot be constructed with 'new' as it is prohibited
        //AccountId GetAccountId() => new(); // error VOG010: Type 'AccountId' cannot be constructed with 'new' as it is prohibited

        // catches argument / parameter expressions
        //Task<AccountId> t = Task.FromResult<AccountId>(new()); // error VOG010: Type 'AccountId' cannot be c
    }

    [Fact]
    public void CastingTest()
    {
        VendorId v = VendorId.From(10);
        //AccountId a = AccountId.From(10);
        AccountId a = 10; // implicit
        //VendorId v = 10; // Error: need explicit cast
        int ai = a; // implicit
        //int vi = v; // Error
        // v = a; // Error
    }

    [Fact]
    public void InitTest()
    {
        VendorId v = (VendorId)10;
        //VendorId v1 = 10; // Error: need explicit cast
        //VendorId v2 = default;
        var a = AccountId.From(10);
        int a1 = AccountId.From(10); // implicit
        var u = AccountId.Unspecified;
        var n = VendorId.None;
    }

    [Fact]
    public void Age_Validation_Fail_Test()
    {
        Assert.Throws<Vogen.ValueObjectValidationException>(() => Age.From(130));

    }

    [Fact]
    public void Age_Comparison_Test()
    {
        var age = Age.From(75);
        Assert.Equal(75, (int)age);
        Assert.True(age == 75);
        Assert.True(age.Equals( 75));
    }
}