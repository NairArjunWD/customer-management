using System;

namespace ACM.BL
{
    public class OrderRepository
    {
        // Retrieve one order

        public Order Retrieve(int orderID)
        {
            // Create the instance of the Order class
            // Pass in the requested id
            Order order = new Order(orderID);

            // Code that retrieves the defined order

            // Temporary hard-coded values to return a populated order
            if (orderID == 10)
            {
                // Use current year in hard-coded data
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }
        // Saves the current order

        public bool Save(Order order)
        {
            // Code that saves the passed in order

            return true;
        }
    }
}