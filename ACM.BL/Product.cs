namespace ACM.BL
{
    public class Product
    {
        public Product()
        {
            
        }

        public Product(int productID)
        {
            ProductId = productID;
        }
        
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }

        // Retrieve one product.
        public Product Retrieve(int productID)
        {
            // Code that retrieves the defined product

            return new Product();
        }
        
        // Saves the current product
        public bool Saves()
        {
            // Code that saves the defined product

            return true;
        }

        // Validates the product data.
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}