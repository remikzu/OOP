using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL.Repositories
{
    class OrderItemRepository
    {
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

        public bool Save(OrderItem orderItem)
        {
            var success = true;

            if (orderItem.HasChanges)
            {
                if (orderItem.isValid)
                {
                    if (orderItem.IsNew)
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
