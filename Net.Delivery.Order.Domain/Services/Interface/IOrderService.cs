using Net.Delivery.Order.Domain.Entities;

namespace Net.Delivery.Order.Domain.Services.Interface
{
    public interface IOrderService
    {
        
        // Creates an order
        // <param name="items">Order items</param>
        // <param name="customer">Order customer</param>
        Task CreateOrder(IList<string> items, Customer customer);

        
        // Updates an order
        // <param name="orderId">Order identification</param>
        // <param name="orderSituation">Order situation</param>
        Task UpdateOrderSituation(string orderId, OrderSituation orderSituation);

        
        // Gets all orders to delivery
        IList<Entities.Order> GetAllOrdersToDelivery();
    }
}