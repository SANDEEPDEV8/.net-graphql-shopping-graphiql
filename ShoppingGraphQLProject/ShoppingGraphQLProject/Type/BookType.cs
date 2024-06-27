using GraphQL.Types;
using ShoppingGraphQL.Models;

namespace ShoppingGraphQL.Type
{
    public class BookType : ObjectGraphType<Book>
    {
        public BookType()
        {
            Field(m => m.Id);
            Field(m => m.Title);
            Field(m => m.Price);
            Field(m => m.Author);
            Field(m => m.ImageUrl);
            Field(m => m.CategoryId);
        }
    }
}
