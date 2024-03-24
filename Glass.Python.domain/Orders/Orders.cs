using System.Collections.Generic;
using Glass.Python.Domain.Catalog;
using System.Linq;

namespace Glass.Python.Domain.Orders
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderItem> Items { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal TotalPrice => Items.Sum(i => i.Price);
    }

    public class OrderItem
    {
        public int Id { get; set; }
        public required Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal Price => Item.Price * Quantity;
    }
}



