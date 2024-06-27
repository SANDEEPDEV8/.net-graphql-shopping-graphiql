using GraphQL;
using GraphQL.Types;
using ShoppingGraphQL.Interfaces;
using ShoppingGraphQL.Models;
using ShoppingGraphQL.Type;

namespace ShoppingGraphQL.Mutation
{
    public class OrderMutation : ObjectGraphType
    {
        public OrderMutation(IOrderRepository orderRepository)
        {
            Field<OrderType>("CreateOrder").Arguments(new QueryArguments(new QueryArgument<OrderInputType> { Name = "Order" })).Resolve(context =>
            {
                return orderRepository.AddOrder(context.GetArgument<Order>("Order"));
            });
        }
    }
}
