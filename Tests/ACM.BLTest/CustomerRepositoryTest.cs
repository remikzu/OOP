﻿using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            var customerRespository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "rzudzin@gmail.com",
                FirstName = "Remigiusz",
                LastName = "Zudzin"
            };
            // Act
            var actual = customerRespository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }
    }
}
