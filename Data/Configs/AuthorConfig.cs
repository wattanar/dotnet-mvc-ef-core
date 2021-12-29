using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configs
{
  public class AuthorConfig : IEntityTypeConfiguration<Author>
  {
    public void Configure(EntityTypeBuilder<Author> builder)
    {
      builder
        .HasMany(x => x.Books)
        .WithOne(x => x.Author)
        .HasForeignKey(x => x.AuthorId)
        .HasPrincipalKey(x => x.Id);
    }
  }
}