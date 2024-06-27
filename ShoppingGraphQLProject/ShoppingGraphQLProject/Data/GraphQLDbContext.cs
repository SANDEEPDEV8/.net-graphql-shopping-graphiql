using ShoppingGraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace ShoppingGraphQL.Data
{
    public class GraphQLDbContext : DbContext
    {
        public GraphQLDbContext(DbContextOptions<GraphQLDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Fiction", ImageUrl = "https://example.com/categories/fiction.jpg" },
                new Category { Id = 2, Name = "Non-Fiction", ImageUrl = "https://example.com/categories/non-fiction.jpg" },
                new Category { Id = 3, Name = "Science Fiction", ImageUrl = "https://example.com/categories/science-fiction.jpg" }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 10.99, ImageUrl = "https://example.com/books/to-kill-a-mockingbird.jpg", CategoryId = 1 },
                new Book { Id = 2, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 12.50, ImageUrl = "https://example.com/books/the-great-gatsby.jpg", CategoryId = 1 },
                new Book { Id = 3, Title = "Sapiens: A Brief History of Humankind", Author = "Yuval Noah Harari", Price = 15.95, ImageUrl = "https://example.com/books/sapiens.jpg", CategoryId = 2 }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, CustomerName = "Alice Johnson", Email = "alicejohnson@example.com", PhoneNumber = "555-123-4567", Quantity = 2, SpecialRequest = "Gift wrapping required.", OrderDate = DateTime.Now.AddDays(7) },
                new Order { Id = 2, CustomerName = "Bob Smith", Email = "bobsmith@example.com", PhoneNumber = "555-987-6543", Quantity = 1, SpecialRequest = "Express delivery needed.", OrderDate = DateTime.Now.AddDays(10) },
                new Order { Id = 3, CustomerName = "Eve Brown", Email = "evebrown@example.com", PhoneNumber = "555-789-0123", Quantity = 3, SpecialRequest = "Include a personal message.", OrderDate = DateTime.Now.AddDays(14) }
            );
        }

    }
}
