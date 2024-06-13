using AutoMapper;
using BenchmarkDotNet.Attributes;

namespace Bnaya.Samples;

public class Benchmark : BenchmarkBase
{
    private IMapper? _mapper;
    private static readonly Person _person = Person.Default;

    #region public void Setup()

    [GlobalSetup]
    public void Setup()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Person, PersonEntity>();
            cfg.CreateMap<PersonEntity, Person>();
            cfg.CreateMap<Address, AddressEntity>();
            //cfg.CreateMap<ImmutableArray<Address>, ImmutableArray<AddressEntity>>()
            //    .ConvertUsing((src, _, context) => src.Select(a => context.Mapper.Map<AddressEntity>(a)).ToImmutableArray());
        });

        _mapper = config.CreateMapper();
    }

    #endregion //  public void Setup()

    [Benchmark]
    public void Generator()
    {
        var entity = _person.ToEntity();
        var person = entity.FromEntity();
        if (!person.Equals(_person))
            throw new Exception("not equals");
    }

    [Benchmark(Baseline = true)]
    public void AutoMap()
    {
        var entity = _mapper?.Map<PersonEntity>(_person);
        var person = _mapper?.Map<Person>(entity);
        if (!person.Equals(_person))
            throw new Exception("not equals");
    }
}
