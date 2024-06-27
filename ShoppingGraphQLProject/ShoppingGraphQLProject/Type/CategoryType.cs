using GraphQL.Types;
using ShoppingGraphQL.Interfaces;
using ShoppingGraphQL.Models;
using ShoppingGraphQL.Services;

namespace ShoppingGraphQL.Type
{
    public class CategoryType : ObjectGraphType<Category>
    {
        public CategoryType(IBookRepository bookRepository)
        {
            Field(c => c.Id);
            Field(c => c.Name);
            Field(c => c.ImageUrl);
            Field<ListGraphType<BookType>>("Books").Resolve(context =>
            {
                return bookRepository.GetAllBooks();
            });
        }
    }
}
