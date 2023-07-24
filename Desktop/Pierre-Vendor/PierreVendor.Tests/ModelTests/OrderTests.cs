using System.Collections.Generic;
using PierreVendor.Models;

namespace PierreVendor.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("Order Test", "Order Description");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
        [TestMethod]
        public void OrderDescription_CheckForOrderDescription_string()
        {
            string orderDescription = "Order Description";
            Order newOrder = new Order ("Order Test", orderDescription);
            Assert.AreEqual(orderDescription, newOrder.Description);
        }
    }
}