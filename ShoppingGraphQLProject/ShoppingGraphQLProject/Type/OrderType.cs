using GraphQL.Types;
using ShoppingGraphQL.Models;

namespace ShoppingGraphQL.Type
{
    public class OrderType : ObjectGraphType<Order>
    {
        public OrderType()
        {
            Field(m => m.Id);
            Field(m => m.CustomerName);
            Field(m => m.Email);
            Field(m => m.PhoneNumber);
            Field(m => m.Quantity);
            Field(m => m.SpecialRequest);
            Field(m => m.OrderDate);
        }
    }
}
