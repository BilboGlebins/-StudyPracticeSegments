using System;
using Otrezki;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OtrezkiUnitTest
{
    [TestClass]
    public class OtrezkiOtrezok1
    {
        [TestMethod]
        public void UnitTestPeresechenie()
        {
            var page = new MainWindow();
            Assert.IsTrue(page.TestPeresechenie(5,5,10, 10, 10, 2, 8, 5));
        }

        [TestMethod]
        public void UnitTestUgol()
        {
            var page = new MainWindow();
            Assert.IsTrue(page.TestUgol(5, 5, 10, 10 , 10, 2, 8, 5));
        }

        [TestMethod]
        public void UnitTestTurn()
        {
            var page = new MainWindow();
            Assert.IsTrue(page.TestTurn(5, 5, 10, 10, 0, 0, 90));
        }

        [TestMethod]
        public void UnitTestContact()
        {
            var page = new MainWindow();
            Assert.IsTrue(page.TestContact(1, 1, 10, 10, 1, 2, 3, 4));
        }
    }
}
