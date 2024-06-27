using GraphQL.Types;
using ShoppingGraphQL.Query;

namespace ShoppingGraphQL.Mutation
{
    public class RootMutation : ObjectGraphType
    {
        public RootMutation()
        {
            Field<BookMutation>("bookMutation").Resolve(context => new { });
            Field<CategoryMutation>("categoryMutation").Resolve(context => new { });
            Field<OrderMutation>("orderMutation").Resolve(context => new { });
        }
    }
}
