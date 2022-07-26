using Store;
using System.Linq;

namespace StoreMemory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "Art of Programming"),
            new Book(2, "Refactoring"),
            new Book(3, "C Programming Language"),
            new Book(4, "Head First Design Patterns")
        };
        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(b => b.Title.Contains(titlePart)).ToArray();
        }
    }
}