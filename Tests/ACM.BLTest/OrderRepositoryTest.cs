using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(1)
            {
                OrderDate = new DateTimeOffset(2019, 12, 11, 11, 43, 21, new TimeSpan(0, 0, 0))
            };
            // Act
            var actual = orderRepository.Retrieve(1);
            // Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
