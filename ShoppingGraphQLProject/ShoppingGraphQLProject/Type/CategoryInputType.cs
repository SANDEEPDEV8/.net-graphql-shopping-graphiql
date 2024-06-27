using GraphQL.Types;

namespace ShoppingGraphQL.Type
{
    public class CategoryInputType : InputObjectGraphType
    {
        public CategoryInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("imageUrl");
        }
    }
}
