using GraphQL;
using GraphQL.Types;
using ShoppingGraphQL.Interfaces;
using ShoppingGraphQL.Type;

namespace ShoppingGraphQL.Query
{
    public class BookQuery : ObjectGraphType
    {
        public BookQuery(IBookRepository bookRepository)
        {
            Field<ListGraphType<BookType>>("Books").Resolve(context =>
            {
                return bookRepository.GetAllBooks();
            });

            Field<BookType>("Book").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "bookId" })).Resolve(context =>
            {
                return bookRepository.GetBookById(context.GetArgument<int>("bookId"));
            });
        }
    }
}
