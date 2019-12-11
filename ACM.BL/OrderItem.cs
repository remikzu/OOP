using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        public bool Validate()
        {
            bool isValid = true;

            if (PurchasePrice == null) isValid = false;
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;

            return isValid;
        }

        public OrderItem Retrieve(int productId)
        {
            //TODO
            return new OrderItem();
        }

        public List<OrderItem> Retrieve()
        {
            //TODO
            return new List<OrderItem>();
        }

        public bool Save()
        {
            //TODO
            return false;
        }
    }
}
