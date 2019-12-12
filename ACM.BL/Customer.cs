using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer(): this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            InstanceCount += 1;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        // Lub, 
        // public Address WorkAddress { get; set; }
        // public Address HomeAddress { get; set; }
        public CustomerType CustomerType { get; set; }
        public int CustomerId { get; private set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (string.IsNullOrWhiteSpace(FirstName))
                {
                    return fullName;
                }
                else if (string.IsNullOrWhiteSpace(LastName))
                {
                    return FirstName;
                }
                else
                {
                    return FirstName + " " + LastName;
                }
            }
        }
        public static int InstanceCount { get; set; }
        public override string ToString() => FullName;

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public Customer Retrieve(int customerId)
        {
            //TODO
            return new Customer();
        }
    }
}
