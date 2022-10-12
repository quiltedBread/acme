﻿using Acme.Common;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer: EntityBase, ILoggable
    {
        public Customer (): this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            Addresses = new List<Address>();
        }
        public List<Address> Addresses { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public static int InstanceCount { get; set; }

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }
        public override string ToString()
        {
            return LastName + ", " + FirstName;
        }
        public string Log() =>
            $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState}";
    }
}
