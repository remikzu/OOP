using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve (int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "rzudzin@gmail.com";
                customer.FirstName = "Remigiusz";
                customer.LastName = "Zudzin";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            // TODO

            return true;
        }
    }
}
