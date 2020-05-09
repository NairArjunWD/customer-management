using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        // Retieve one address
        public Address Retrieve(int addressID)
        {
            
            // Create the instance of the Address class 
            // Pass in the requested Id
            Address address = new Address(addressID);

            // Code that retrieves the defined address

            // Temporary hard coded values to return a populated address
            if (addressID == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }
        
        // Saves the current address
        public bool Saves(Address address)
        {
            // Code that saves the passed in address

            return true;
        }
    }
}