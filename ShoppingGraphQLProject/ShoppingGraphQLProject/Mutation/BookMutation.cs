using GraphQL;
using GraphQL.Types;
using ShoppingGraphQL.Interfaces;
using ShoppingGraphQL.Models;
using ShoppingGraphQL.Type;

namespace ShoppingGraphQL.Mutation
{
    public class BookMutation : ObjectGraphType
    {
        public BookMutation(IBookRepository bookRepository)
        {
            Field<BookType>("CreateBook").Arguments(new QueryArguments(new QueryArgument<BookInputType> { Name = "book" })).Resolve(context =>
            {
                return bookRepository.AddBook(context.GetArgument<Book>("book"));
            });

            Field<BookType>("UpdateBook").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "bookId" },
                new QueryArgument<BookInputType> { Name = "book" })).Resolve(context =>
            {
                var book = context.GetArgument<Book>("book");
                var bookId = context.GetArgument<int>("bookId");
                return bookRepository.UpdateBook(bookId, book);
            });

            Field<StringGraphType>("DeleteBook").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "bookId" })).Resolve(context =>
               {

                   var bookId = context.GetArgument<int>("bookId");
                   bookRepository.DeleteBook(bookId);
                   return "The book against this Id" + bookId + "has been deleted";
               });
        }
    }
}
