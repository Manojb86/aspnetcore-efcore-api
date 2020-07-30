using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiEFCore.Model
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ItemNumber { get; set; }
        public string Description { get; set; }

        public Order Order { get; set; }
    }
}
