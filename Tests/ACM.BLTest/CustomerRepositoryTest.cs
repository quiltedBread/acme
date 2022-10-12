 using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "mharper@yahoo.com",
                FirstName = "Matt",
                LastName = "Harper"
            };
            // act
            var actual = customerRepository.Retrieve(1);
            // assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            // arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "mharper@yahoo.com",
                FirstName = "Matt",
                LastName = "Harper",
                Addresses = new List<Address>()
                {
                    new Address(1)
                    {
                        AddressType = 1,
                        StreetLine1 = "400 Oak St.",
                        StreetLine2 = "Unit 1",
                        City = "Cincinnati",
                        State = "OH",
                        PostalCode = "123",
                        Country = "US"

                    },
                    new Address(2)
                    {
                        AddressType = 1,
                        StreetLine1 = "401 Oak St.",
                        StreetLine2 = "Unit 1",
                        City = "Cincinnati",
                        State = "OH",
                        PostalCode = "123",
                        Country = "US"

                    }
                }
            };
            // act
            var actual = customerRepository.Retrieve(1);
            // assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.Addresses[0].AddressType, actual.Addresses[0].AddressType);
            Assert.AreEqual(expected.Addresses[0].StreetLine1, actual.Addresses[0].StreetLine1);
            Assert.AreEqual(expected.Addresses[0].StreetLine2, actual.Addresses[0].StreetLine2);
            Assert.AreEqual(expected.Addresses[0].AddressId, actual.Addresses[0].AddressId);
        }
    }
}
