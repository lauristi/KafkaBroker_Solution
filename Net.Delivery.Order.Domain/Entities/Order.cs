namespace Net.Delivery.Order.Domain.Entities
{
    // Order entity

    public class Order
    {
        // Order id
        public string OrderId { get; set; }

        // Order date
        public DateTime OrderCreateDate { get; set; }

        // Order last update
        public DateTime OrderLastUpdate { get; set; }

        // Order`s situation
        public OrderSituation OrderSituation { get; set; }

        // Order`s items
        public IList<string> Items { get; set; }

        // Order`s customer
        public Customer Customer { get; set; }

        // Order builder

        // <param name="items">Order items</param>
        // <param name="customer">Order customer</param>
        public Order(IList<string> items, Customer customer)
        {
            OrderId = Guid.NewGuid().ToString();
            OrderCreateDate = DateTime.Now;
            OrderLastUpdate = OrderCreateDate;
            OrderSituation = OrderSituation.CREATED;
            Items = items;
            Customer = customer;
        }

        public Order()
        {
        }
    }
}