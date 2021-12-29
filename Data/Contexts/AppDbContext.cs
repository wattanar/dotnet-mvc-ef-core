using Data.Configs;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.ApplyConfiguration(new BookConfig());
      builder.ApplyConfiguration(new AuthorConfig());
    }

    public DbSet<Book> Book { get; set; }
    public DbSet<Author> Author { get; set; }
  }
}