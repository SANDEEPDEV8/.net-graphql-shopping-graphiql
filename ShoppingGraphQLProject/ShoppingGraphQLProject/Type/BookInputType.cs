using GraphQL.Types;

namespace ShoppingGraphQL.Type
{
    public class BookInputType : InputObjectGraphType
    {
        public BookInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("title");
            Field<StringGraphType>("author");
            Field<FloatGraphType>("price");
            Field<StringGraphType>("imageUrl");
            Field<IntGraphType>("categoryId");
        }
    }
}
