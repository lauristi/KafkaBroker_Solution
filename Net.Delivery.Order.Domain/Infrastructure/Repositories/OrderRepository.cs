using Net.Delivery.Order.Domain.Entities;
using Net.Delivery.Order.Domain.Infrastructure.Repositories.Interface;

namespace Net.Delivery.Order.Domain.Infrastructure.Repositories
{

    // Order repository
    public class OrderRepository : IOrderRepository
    {

        // This is like a memory database
        private static IList<Entities.Order> _orderDataBase = new List<Entities.Order>();


        // Add an order into database
        // <param name="order">Order's data</param>
        public void Add(Entities.Order order)
        {
            _orderDataBase.Add(order);
        }

        
        // Get all orders from database
        // <returns>All orders</returns>
        public IList<Entities.Order> GetAll()
        {
            return _orderDataBase.ToList();
        }

        
        // Get an order from database by its id
        // <returns>Order related to the id asked</returns>
        public Entities.Order GetOrderById(string OrderId)
        {
            Entities.Order orderRecovered = _orderDataBase.FirstOrDefault(o => o.OrderId.Equals(OrderId));

            if (orderRecovered == null)
                throw new Exception("Order not found");

            return orderRecovered;
        }

        
        // Get all orders from database for determined situation
        // <returns>All orders those have the requested situation</returns>
        public IList<Entities.Order> GetOrdersBySituation(OrderSituation orderSituation)
        {
            return _orderDataBase.Where(o => o.OrderSituation == orderSituation).ToList();
        }

        
        // Update an order to database
        // <param name="order">Order's data</param>
        public void Update(Entities.Order order)
        {
            Entities.Order orderRecovered = GetOrderById(order.OrderId);

            orderRecovered.OrderSituation = order.OrderSituation;
        }
    }
}