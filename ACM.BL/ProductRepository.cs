using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {

            if (productId == 1)
            {
                var product = new Product(productId)
                {
                    ProductName = "Komputer",
                    Description = "Test Description",
                    CurrentPrice = 12.55M
                };

                return product;
            }

            return null;
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            // TODO

            return true;
        }
    }
}
