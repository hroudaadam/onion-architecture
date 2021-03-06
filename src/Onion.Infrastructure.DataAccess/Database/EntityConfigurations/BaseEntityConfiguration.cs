using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Application.DataAccess.Database.Entities;
using Onion.Core.Helpers;

namespace Onion.Infrastructure.DataAccess.Database.EntityConfigurations;

public abstract class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        Guard.NotNull(builder, nameof(builder));

        builder.ToTable(typeof(T).Name);
        builder.HasKey(e => e.Id);
    }
}
