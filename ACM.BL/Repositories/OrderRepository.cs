using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepository
    {

        public Order Retrieve(int orderId)
        {
            if (orderId == 1)
            {
                var order = new Order(orderId)
                {
                    OrderDate = new DateTimeOffset(2019, 12, 11, 11, 43, 21, new TimeSpan(0, 0, 0))
                };

                return order;
            }

            return null;
        }

        public List<Order> Retrieve()
        {
            // TODO

            return new List<Order>();
        }

        public bool Save(Order order)
        {
            var success = true;

            if (order.HasChanges)
            {
                if (order.isValid)
                {
                    if (order.IsNew)
                    {
                        // Call an Insert Stored Procedure
                    }
                    else
                    {
                        // Call an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }

    }
}
