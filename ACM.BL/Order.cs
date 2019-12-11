using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public int OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null) isValid = false; ;

            return isValid;
        }
    }
}
