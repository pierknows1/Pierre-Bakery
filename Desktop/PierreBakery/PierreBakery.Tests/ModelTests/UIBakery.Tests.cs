using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.ModelTests
{
    [TestClass]
    public class UIOrderTest
    {
        [TestMethod]
        public void UI_CreateInstanceOfUIOrder()
        {
            UIBakery newUI = new UIBakery(0, 0);
            Assert.AreEqual(typeof(UIBakery), newUI.GetType());
        }
    [TestMethod]
        public void UI_GetQuantityBread()
        {
            int breadQuantity = 2;
            Bread newBread = new Bread(breadQuantity);
            UIBakery newUI = new UIBakery(breadQuantity, 0);
            Assert.AreEqual(newBread.Quantity, newUI.BreadOrder.Quantity);
        }
    [TestMethod]
        public void UI_GetTotalBreadAndPastry()
        {
            int breadQuantity = 2;
            int pastryQuantity = 5;
            Bread newBread = new Bread(breadQuantity);
            Pastry newPastry = new Pastry(pastryQuantity);
            UIBakery newUI = new UIBakery(breadQuantity, pastryQuantity);
            Assert.AreEqual(newBread.Quantity, newUI.BreadOrder.Quantity);
            Assert.AreEqual(newPastry.Quantity, newUI.PastryOrder.Quantity);
        }
    
        [TestMethod]
        public void UI_GetTotalCostBreadAndPastry()
        {
            int breadQuantity = 4;
            int pastryQuantity = 8;
            Bread newBread = new Bread(breadQuantity);
            Pastry newPastry = new Pastry(pastryQuantity);
            UIBakery newUI = new UIBakery(breadQuantity, pastryQuantity);
            int getTotal = newUI.TotalCost();
            int newTotal = (newBread.BreadTotal()) + (newPastry.PastryTotal());
            Assert.AreEqual(getTotal, newTotal);
        }
    }

}