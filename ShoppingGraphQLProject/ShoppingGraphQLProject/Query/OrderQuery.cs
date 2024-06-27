using GraphQL;
using GraphQL.Types;
using ShoppingGraphQL.Interfaces;
using ShoppingGraphQL.Services;
using ShoppingGraphQL.Type;

namespace ShoppingGraphQL.Query
{
    public class OrderQuery : ObjectGraphType
    {
        public OrderQuery(IOrderRepository orderRepository)
        {
            Field<ListGraphType<OrderType>>("Orders").Resolve(context =>
            {
                return orderRepository.GetOrders();
            });
        }
    }
}
