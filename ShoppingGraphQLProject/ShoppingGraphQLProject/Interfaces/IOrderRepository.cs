using ShoppingGraphQL.Models;

namespace ShoppingGraphQL.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        Order AddOrder(Order order);
    }
}
