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
        [TestMethod]
        public void SaveTestCorrectEverything()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(1)
            {
                CurrentPrice = 12.55M,
                Description = "Test Description",
                ProductName = "Komputer",
                HasChanges = true
            };
            // Act
            var actual = productRepository.Save(updatedProduct);
            // Assert
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void SaveTestMissingPrice()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(1)
            {
                CurrentPrice = null,
                Description = "You shouldnt match",
                ProductName = "Komputer",
                HasChanges = true
            };
            // Act
            var actual = productRepository.Save(updatedProduct);
            // Assert
            Assert.AreEqual(false, actual);
        }
    }
}
