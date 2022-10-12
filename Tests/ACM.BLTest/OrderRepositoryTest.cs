using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(1)
            {
               OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };
            // act
            var actual = orderRepository.Retrieve(1);
            // assert
            Assert.AreEqual(expected.OrderId, actual.OrderId);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
