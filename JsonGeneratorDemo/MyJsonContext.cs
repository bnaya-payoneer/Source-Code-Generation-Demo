using System.Collections.Immutable;
using System.Text.Json.Serialization;

namespace Bnaya.Samples;

[JsonSerializable(typeof(Fellow))]
[JsonSerializable(typeof(Account))]
[JsonSerializable(typeof(Account[]))]
[JsonSerializable(typeof(IImmutableList<Account>))]
[JsonSerializable(typeof(Person))]
[JsonSerializable(typeof(Person[]))]

[JsonSourceGenerationOptions(
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
//[JsonSourceGenerationOptions(
//    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
//    UseStringEnumConverter = true)]
internal partial class MyJsonContext : JsonSerializerContext
{
}

