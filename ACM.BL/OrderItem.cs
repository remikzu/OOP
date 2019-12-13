using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem : EntityBase
    {
        public OrderItem() : this(0)
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
        public override string ToString() => $"ProductId: {ProductId}, Qty: {Quantity}";

        public override bool Validate()
        {
            bool isValid = true;

            if (PurchasePrice == null) isValid = false;
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;

            return isValid;
        }

        
    }
}
