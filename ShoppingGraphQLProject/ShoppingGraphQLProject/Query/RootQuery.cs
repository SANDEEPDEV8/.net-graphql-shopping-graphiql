using GraphQL.Types;

namespace ShoppingGraphQL.Query
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Field<BookQuery>("bookQuery").Resolve(context => new { });
            Field<CategoryQuery>("categoryQuery").Resolve(context => new { });
            Field<OrderQuery>("orderQuery").Resolve(context => new { });
        }
    }
}
