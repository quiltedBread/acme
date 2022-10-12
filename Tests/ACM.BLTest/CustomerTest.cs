using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // arrange
            var customer = new Customer
            {
                FirstName = "Matt",
                LastName = "Harper"
            };
            string expected = "Harper, Matt";
            // act
            string actual = customer.FullName;
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // arrange
            var customer = new Customer
            {
                LastName = "Harper"
            };
            string expected = "Harper";
            // act
            string actual = customer.FullName;
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // arrange
            var customer = new Customer
            {
                FirstName = "Matt"
            };
            string expected = "Matt";
            // act
            string actual = customer.FullName;
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            // arrange
            var c1 = new Customer()
            {
                FirstName = "Bob"
            };
            Customer.InstanceCount += 1;
            var c2 = new Customer()
            {
                FirstName = "Roger"
            };
            Customer.InstanceCount += 1;
            var c3 = new Customer()
            {
                FirstName = "Velma"
            };
            Customer.InstanceCount += 1;

            // act

            // assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
        [TestMethod]
        public void ValidateValid()
        {
            // arrange
            var customer = new Customer()
            {
                LastName = "Harper",
                EmailAddress = "mharper@yahoo.com"
            };
            // act
            var actual = customer.Validate();
            // assert
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            // arrange
            var customer = new Customer()
            {
                EmailAddress = "mharper@yahoo.com"
            };
            // act
            var actual = customer.Validate();
            // assert
            Assert.AreEqual(false, actual);
        }
    }
}
