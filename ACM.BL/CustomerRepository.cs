using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository {get; set;}
        // Retrieve one customer

        public Customer Retrieve(int customerID)
        {
            // Create the instance of the Customer class
            // Pass in the requested id
            Customer customer = new Customer(customerID);

            // Code that retrieves the defined customer

            // Temporary hard-coded values to return a populated customer
            if (customerID == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerID).ToList();
            }
            return customer;
        }
        // Saves the current customer

        public bool Save(Customer customer)
        {
            // Code that saves the passed in customer

            return true;
        }
    }
}