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

        // Retrieve one order.
        public Order Retrieve(int orderID)
        {
            // Code that retrieves the defined order

            return new Order();
        }

        // Saves the current order
        public bool Saves()
        {
            // Code that saves the defined order

            return true;
        }

        // Validates the order data.
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}