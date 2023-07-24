using System.Collections.Generic;
using PierreVendor.Models;

namespace PierreVendor.Tests
{
    [TestClass]
    public class OrderTests{
        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order();
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
    }
}