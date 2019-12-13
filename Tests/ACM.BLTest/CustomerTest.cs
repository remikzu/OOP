using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "Remigiusz";
            customer.LastName = "Zudzin";
            string expected = "Remigiusz Zudzin";
            // Act
            string actual = customer.FullName;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Remigiusz"
            };
            string expected = "Remigiusz";
            // Act
            string actual = customer.FullName;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            var customer = new Customer
            {
                LastName = "Zudzin"
            };
            string expected = "Zudzin";
            // Act
            string actual = customer.FullName;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer
            {
                FirstName = "Remigiusz"
            };

            var c2 = new Customer
            {
                FirstName = "Katarzyna"
            };

            var c3 = new Customer
            {
                FirstName = "Radoslaw"
            };

            int expected = 3;

            //Act
            int actual = Customer.InstanceCount;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer
            {
                LastName = "Zudzin",
                EmailAddress = "rzudzin@gmail.com"
            };

            var expected = true;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange
            var customer = new Customer
            {
                EmailAddress = "rzudzin@gmail.com"
            };

            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
