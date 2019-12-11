using System;
using System.Collections.Generic;
using ACM.BL;
using System.Text;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = AddressType.HomeAddress;
                address.StreetLine1 = "Line1";
                address.StreetLine2 = "Line2";
                address.City = "Bydgoszcz";
                address.State = "Kujawsko Pomorskie";
                address.PostalCode = "85-123";
                address.Country = "Polska";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = AddressType.HomeAddress,
                StreetLine1 = "Line1",
                StreetLine2 = "Line2",
                City = "Bydgoszcz",
                State = "Kujawsko - Pomorskie",
                Country = "Polska",
                PostalCode = "85-123"
            };
            addressList.Add(address);

            Address address2 = new Address(2)
            {
                AddressType = AddressType.HomeAddress,
                StreetLine1 = "Line3",
                StreetLine2 = "Line4",
                City = "Bydgoszcz",
                State = "Kujawsko - Pomorskie",
                Country = "Polska",
                PostalCode = "85-113"
            };
            addressList.Add(address2);

            return addressList;

        }

        public bool Save()
        {
            //TODO

            return true;
        }
    }
}
