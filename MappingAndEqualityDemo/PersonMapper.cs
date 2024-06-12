using Riok.Mapperly.Abstractions;

namespace Bnaya.Samples;

[Mapper]
public static partial class PersonMapper
{
    public static partial PersonEntity ToEntity(this Person person);
    public static partial Person FromEntity(this PersonEntity person);
}