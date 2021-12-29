using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configs
{
  public class BookConfig : IEntityTypeConfiguration<Book>
  {
    public void Configure(EntityTypeBuilder<Book> builder)
    {
      builder
        .HasOne(x => x.Author)
        .WithMany(x => x.Books)
        .HasForeignKey(x => x.AuthorId)
        .HasPrincipalKey(x => x.Id);
    }
  }
}