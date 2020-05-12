using System;
using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL
{
    public class Product: EntityBase
    {
        private string _productName;

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
        public string ProductName
        {
            get
            {
                var stringHandler = new StringHandler();
                return stringHandler.InsertSpaces(_productName);
            }
            set
            {
                _productName = value;
            }
        }

        public override string ToString() => ProductName;

        // Validates the product data.
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}