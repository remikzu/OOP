using Acme.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {
            InstanceCount += 1;
        }
        public Product(int productId)
        {
            ProductId = productId;
            InstanceCount += 1;
        }
        public int ProductId { get; private set; }
        private string _productName;
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
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }
        public static int InstanceCount { get; set; }

        /*public override string ToString()
        {
            return ProductName;
        }*/
        //lub

        public override string ToString() => ProductName;
        public string Log() => $"{ProductId} {ProductName}, Price: {CurrentPrice}, Status: {EntityState.ToString()}";
        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) return false;
            if (CurrentPrice == null) return false;

            return isValid;
        }
    }
}
