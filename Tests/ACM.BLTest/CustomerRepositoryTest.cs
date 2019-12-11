using System;
using System.Collections.Generic;
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
        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            // Arrange

            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "rzudzin@gmail.com",
                FirstName = "Remigiusz",
                LastName = "Zudzin",
                AddressList = new List<Address>()
                {
                      new Address()
                      {
                          AddressType = AddressType.HomeAddress,
                          StreetLine1 = "Line1",
                          StreetLine2 = "Line2",
                          City = "Bydgoszcz",
                          State = "Kujawsko - Pomorskie",
                          Country = "Polska",
                          PostalCode = "85-123"
                      },
                      new Address()
                      {
                          AddressType = AddressType.HomeAddress,
                          StreetLine1 = "Line3",
                          StreetLine2 = "Line4",
                          City = "Bydgoszcz",
                          State = "Kujawsko - Pomorskie",
                          Country = "Polska",
                          PostalCode = "85-113"
                      }
                }
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
