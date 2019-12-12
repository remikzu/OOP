using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product
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
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }
        public static int InstanceCount { get; set; }

        /*public override string ToString()
        {
            return ProductName;
        }*/
        //lub

        public override string ToString() => ProductName;
        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) return false;
            if (CurrentPrice == null) return false;

            return isValid;
        }
    }
}
