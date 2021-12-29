using System.Collections;

namespace Data.Entities
{
  public class Author
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Book> Books { get; set; }
  }
}