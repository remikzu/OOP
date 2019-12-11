using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve (int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "rzudzin@gmail.com";
                customer.FirstName = "Remigiusz";
                customer.LastName = "Zudzin";
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
