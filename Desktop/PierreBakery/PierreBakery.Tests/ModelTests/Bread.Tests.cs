using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.ModelTests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void Bread_CreateInstanceofBread()
        {
            Bread newBread = new Bread(0);
            
            Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
        [TestMethod]
        public void Bread_CreateQuantityandCostBread()
        {
            Bread newBread = new Bread(1);
            int price = 5;
            int quantity = 1;
            Assert.AreEqual(price, newBread.Price);
            Assert.AreEqual(quantity, newBread.Quantity);
        }
        [TestMethod]
        public void Bread_CreateTotalCostBread()
        {
           
            int quantity = 2;
            Bread newBread = new Bread(quantity);
            Assert.AreEqual(10, newBread.BreadTotal());
        }
        [TestMethod]
        public void Bread_BOGO_3Breads()
        {
            Bread breadOrder = new Bread(3);
            int breadTotal = breadOrder.CalculateBogo();
            Assert.AreEqual(10, breadTotal);
        }
        [TestMethod]
        public void Bread_X_Bogo_Bread()
        {
            Bread breadOrder = new Bread(6);
            int breadTotal = breadOrder.CalculateXBogo();
            Assert.AreEqual(20, breadTotal);
        }
    }
}