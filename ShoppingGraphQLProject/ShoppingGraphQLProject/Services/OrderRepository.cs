using ShoppingGraphQL.Data;
using ShoppingGraphQL.Interfaces;
using ShoppingGraphQL.Models;

namespace ShoppingGraphQL.Services
{
    public class OrderRepository : IOrderRepository
    {
        private GraphQLDbContext dbContext;
        public OrderRepository(GraphQLDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Order AddOrder(Order order)
        {
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
            return order;
        }

        public List<Order> GetOrders()
        {
            return dbContext.Orders.ToList();
        }
    }
}
