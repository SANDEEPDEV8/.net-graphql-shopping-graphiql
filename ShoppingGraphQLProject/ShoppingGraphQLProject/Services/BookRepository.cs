using Microsoft.AspNetCore.Mvc;
using ShoppingGraphQL.Data;
using ShoppingGraphQL.Interfaces;
using ShoppingGraphQL.Models;

namespace ShoppingGraphQL.Services
{
    public class BookRepository : IBookRepository
    {
        private GraphQLDbContext dbContext;

        public BookRepository(GraphQLDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Book AddBook(Book book)
        {
            dbContext.Books.Add(book);
            dbContext.SaveChanges();
            return book;
        }

        public void DeleteBook(int id)
        {
            var bookResult = dbContext.Books.Find(id);
            dbContext.Books.Remove(bookResult);
            dbContext.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            return dbContext.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return dbContext.Books.Find(id);
        }

        public Book UpdateBook(int id, Book book)
        {
            var bookResult = dbContext.Books.Find(id);
            bookResult.Title = book.Title;
            bookResult.Author = book.Author;
            bookResult.Price = book.Price;
            dbContext.SaveChanges();
            return bookResult;
        }
    }
}
