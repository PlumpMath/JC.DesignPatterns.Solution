using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using JC.DesignPatterns.Lib;
namespace JC.DesignPatterns.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFactoryMethod()
        {
            List<Product> electronicProducts = new List<Product>();
            ElectronicProductSupplier supplier = new ElectronicProductSupplier();
            electronicProducts.Add(supplier.SupplyProduct(99.99,"IPhone","IPhone 5s"));
            electronicProducts.Add(supplier.SupplyProduct(49.99,"Galaxy 4","Samsung Galaxy 4s"));

            Assert.AreEqual(electronicProducts[0].Name, "IPhone");
        }
    }
}
