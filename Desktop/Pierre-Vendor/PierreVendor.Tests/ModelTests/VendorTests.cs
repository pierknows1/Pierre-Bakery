using System.Collections.Generic;
using PierreVendor.Models;

namespace PierreVendor.Tests
{
     [TestClass]
    public class VendorTests{
        [TestMethod]
        public void VendorConstructor_CreateInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor();
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }
    }
}