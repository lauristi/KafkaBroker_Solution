using Net.Delivery.Order.Domain.Services.Interface;

namespace Net.Delivery.Order.Domain.Services
{
    
    // Notifier service
    
    public class NotifierService : INotifierService
    {
        
        // Notifies the customer about some order update
        // <param name="order">Order data</param>
        public void Notify(Entities.Order order)
        {
            SendEmail(order.Customer.Email);
        }

        
        // Sends email about order update to customer
        // <param name="customer">Customer data</param>
        private void SendEmail(string email)
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine($"O Notifier disparou um serviço de terceiros em:{DateTime.Now.ToString() }");
            Console.WriteLine($"Email sent to recipient:{email}");
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}