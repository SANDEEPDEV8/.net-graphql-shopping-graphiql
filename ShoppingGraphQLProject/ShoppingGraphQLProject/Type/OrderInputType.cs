using GraphQL.Types;

namespace ShoppingGraphQL.Type
{
    public class OrderInputType : InputObjectGraphType
    {
        public OrderInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("customerName");
            Field<StringGraphType>("email");
            Field<StringGraphType>("phoneNumber");
            Field<IntGraphType>("quantity");
            Field<StringGraphType>("specialRequest");
            Field<DateGraphType>("orderDate");

        }
    }
}
