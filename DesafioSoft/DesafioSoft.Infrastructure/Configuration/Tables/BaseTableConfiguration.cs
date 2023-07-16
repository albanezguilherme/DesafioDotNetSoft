using DesafioSoft.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DesafioSoft.Infrastructure.Configuration.Tables
{
    public abstract class BaseTableConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
      where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
