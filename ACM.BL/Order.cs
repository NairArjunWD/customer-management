using System;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderID)
        {
            OrderId = orderID;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        // Validates the order data.
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}