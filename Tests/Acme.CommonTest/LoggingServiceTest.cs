using Acme.Common;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            // arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "emailaddress",
                FirstName = "bob",
                LastName = "bob",
                Addresses = null
            };
            changedItems.Add(customer);

            var product = new Product(1)
            {
                Name = "productname",
                Description = "description",
                Price = 6M
            };
            changedItems.Add(product);

            // act
            LoggingService.WriteToFile(changedItems);
            // assert 
            //not checking file contents here
        }
    }
}
