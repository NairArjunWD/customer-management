using System;
using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL
{
    public class Product: EntityBase, ILoggable
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
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }

        public string Log() =>
            $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";

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