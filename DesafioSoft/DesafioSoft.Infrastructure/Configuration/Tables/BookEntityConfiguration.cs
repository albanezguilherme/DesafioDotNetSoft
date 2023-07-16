using DesafioSoft.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioSoft.Infrastructure.Configuration.Tables
{
    public class BookEntityConfiguration : BaseTableConfiguration<Book>
    {
        public override void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.Title)
                .IsRequired();

            builder.Property(x => x.Year)
                .IsRequired();

            builder.Property(x => x.Author)
                .IsRequired();
        }
    }
}
