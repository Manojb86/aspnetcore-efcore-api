using System.Collections.Generic;

namespace WebApiEFCore.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ItemDescription { get; set; }
        public double Value { get; set; }

        public Customer Customer { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
