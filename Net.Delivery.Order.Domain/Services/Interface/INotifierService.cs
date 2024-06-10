namespace Net.Delivery.Order.Domain.Services.Interface
{
    
    // Notifier contract service
    public interface INotifierService
    {
        
        // Notifies the customer about some order update
        // <param name="order">Order data</param>
        void Notify(Entities.Order order);
    }
}