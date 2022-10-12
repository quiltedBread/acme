using Acme.Common;
using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order: EntityBase, ILoggable
    {
        public Order(): this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItems { get; set; }
        public DateTimeOffset? OrderDate { get; set; }

        public override bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
        public Order Retrieve(int orderId)
        {
            var order = new Order();
            return order;
        }
        public bool Save()
        {
            return true;
        }
        public override string ToString()
        {
            return CustomerId.ToString();
        }

        public string Log() =>
            $"{OrderId}: Date: {OrderDate.Value.Date} Status: {EntityState}";
    }
}
