
using System.Collections.Generic;
using PierreVendor.Models;
using System;

namespace PierreVendor.Tests
{
     [TestClass]
    public class VendorTests{
        [TestMethod]
        public void VendorConstructor_CreateInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("name", "description");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }
    
        [TestMethod]
        public void Vendorname_ChecksName_Vendor()
        {
            string vendorName = "Vendor's name";
            Vendor newVendor = new Vendor(vendorName, "Description");
            Assert.AreEqual(vendorName, newVendor.Name);
        }

        [TestMethod]
        public void VendorDescription_CreateDescription_Vendor()
        {
            string vendorDescription = "Description";
            Vendor newVendor = new Vendor("Vendor's name", vendorDescription);
            Assert.AreEqual(vendorDescription, newVendor.Description);

        }

    }
}