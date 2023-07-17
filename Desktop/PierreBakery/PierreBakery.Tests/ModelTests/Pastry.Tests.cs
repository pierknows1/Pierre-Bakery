using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.ModelTests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void Pastry_CreateInstanceofPastry()
        {
            Pastry newPastry = new Pastry(0);
            
            Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
        [TestMethod]
        public void Pastry_QuantityAndCostOfPastry()
        {
            Pastry newPastry = new Pastry(1);
            int price = 2;
            int quantity = 1;
            Assert.AreEqual(price, newPastry.Price);
            Assert.AreEqual(quantity, newPastry.Quantity);
        }
        [TestMethod]
        public void Pastry_PastryBogoTest()
        {
            int quantity = 8;
            Pastry newPastry = new Pastry(quantity);
            int result = newPastry.PastryTotal();
            Assert.AreEqual(12, result);
        }
    }
}
    