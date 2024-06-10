using Net.Delivery.Order.Domain.Entities;

namespace Net.Delivery.Order.Domain.Infrastructure.Repositories.Interface
{
    
    // Order repository
    
    public interface IOrderRepository
    {
        
        // Add an order into database
        // <param name="order">Order's data</param>
        void Add(Entities.Order order);

        
        // Update an order to database
        // <param name="order">Order's data</param>
        void Update(Entities.Order order);

        
        // Get all orders from database
        // <returns>All orders</returns>
        IList<Entities.Order> GetAll();

        
        // Get an order from database by its id
        // <returns>Order related to the id requested</returns>
        Entities.Order GetOrderById(string OrderId);

        
        // Get all orders from database for determined situation
        // <returns>All orders those have the requested situation</returns>
        IList<Entities.Order> GetOrdersBySituation(OrderSituation orderSituation);
    }
}