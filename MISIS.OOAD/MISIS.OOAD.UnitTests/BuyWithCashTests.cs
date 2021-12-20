using Microsoft.VisualStudio.TestTools.UnitTesting;
using MISIS.OOAD.COMMON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISIS.OOAD.UnitTests
{
    [TestClass]
    public class BuyWithCashTests
    {
        [TestMethod]
        public void BuyWithCash_Success()
        {
            //Arrange
            var machine = new Machine();
            machine.FillWithMoney(
                new Dictionary<Banknotes, int>() { { Banknotes.Fifty, 5 } },
                new Dictionary<Coins, int>() { { Coins.Five, 5 } });

            machine.Load(new TestFood[] { new TestFood(10, "test"), new TestFood(10, "test") });

            //Act
            machine.Buy<TestFood>(2,
                new Dictionary<Banknotes, int> { { Banknotes.Ten, 2 } },
                new Dictionary<Coins, int>());

            //Assert
            Assert.AreEqual(0, machine.Foods.Count());
            Assert.IsTrue(machine.Banknotes.ContainsKey(Banknotes.Ten));
            Assert.AreEqual(2, machine.Banknotes[Banknotes.Ten]);
        }
    }
}