using Store;
using System.Linq;

namespace StoreMemory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "Art of Programming", "ISBN 12312-31231", "D. Knuth"),
            new Book(2, "Refactoring", "ISBN 12312-31232", "M. Fowler"),
            new Book(3, "C Programming Language","ISBN 12312-31233", "B. Kernighan, D. Ritchie"),
            new Book(4, "Head First Design Patterns", "ISBN 12312-31234", "E. Friemen, E. Robson")
        };

        public Book[] GetAllByIsbn(string isbn)
        {
           return books.Where(x => x.Isbn == isbn).ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string titlePart)
        {
            return books.Where(b => b.Title.Contains(titlePart)
            || b.Author.Contains(titlePart)).ToArray();
        }
    }
}