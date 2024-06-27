using ShoppingGraphQL.Models;

namespace ShoppingGraphQL.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        Book AddBook(Book book);
        Book UpdateBook(int id, Book book);
        void DeleteBook(int id);
    }
}
