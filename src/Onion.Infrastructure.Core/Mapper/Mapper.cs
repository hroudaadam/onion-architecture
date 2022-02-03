﻿using Onion.Core.Helpers;
using Onion.Core.Mapper;
using AM = AutoMapper;

namespace Onion.Infrastructure.Core.Mapper;

public class Mapper : IMapper
{
    private readonly AM.Mapper _mapper;

    public Mapper()
    {
        AM.MapperConfiguration configuration = new(MappperProfile.Configure);
        _mapper = new(configuration);
    }

    public TDest Map<TSource, TDest>(TSource source, Action<TDest> additionalProperties = null)
    {
        Guard.NotNull(source, nameof(source));

        return _mapper.Map<TSource, TDest>(source, opts =>
        {
            opts.AfterMap((s, d) =>
            {
                additionalProperties?.Invoke(d);
            });
        });
    }
}
