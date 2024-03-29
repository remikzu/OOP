﻿using Acme.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order() : this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }

        public string Log() => $"Id: {CustomerId}, OrderId: {OrderId}, Order date: {this.OrderDate.Value.Date}, Status: {this.EntityState.ToString()}";

        public override string ToString() => $"Order date: {OrderDate.Value.Date}, Id: {OrderId}";

        public override bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null) isValid = false; ;

            return isValid;
        }
    }
}
