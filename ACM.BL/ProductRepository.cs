using System;

namespace ACM.BL
{
    public class ProductRepository
    {
        // Retrieve one product

        public Product Retrieve(int productID)
        {
            // Create the instance of the Product class
            // Pass in the requested id
            Product product = new Product(productID);

            // Code that retrieves the defined product

            // Temporary hard-coded values to return a populated product
            if (productID == 2)
            {
                product.ProductName = "Sunflower";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }
        // Saves the current product

        public bool Save(Product product)
        {
            // Code that saves the passed in product

            return true;
        }
    }
}