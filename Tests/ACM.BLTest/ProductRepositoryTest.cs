using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange

            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                ProductName = "Komputer",
                Description = "Test Description",
                CurrentPrice = 12.55M
            };

            // Act
            var actual = productRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }
    }
}
