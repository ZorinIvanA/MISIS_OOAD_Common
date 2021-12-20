using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MISIS.OOAD.COMMON;
using MISIS.OOAD.COMMON.Foods;

namespace MISIS.OOAD.UnitTests
{
    [TestClass]
    public class MoneyTests
    {
        [TestMethod]
        public void FillWithMoney_Success()
        {
            //Arrange
            Machine machine = new Machine();
            Dictionary<Banknotes, int> banknotes = new Dictionary<Banknotes, int>()
            {
                { Banknotes.Fifty, 5 },
                { Banknotes.FiveHudreds, 5 }
            };
            Dictionary<Coins, int> coins = new Dictionary<Coins, int>()
            {
                { Coins.Five, 5 },
                { Coins.One, 5 }
            };

            //Act
            machine.FillWithMoney(banknotes, coins);

            //Assert
            Assert.AreEqual(2, machine.Banknotes.Count);
            Assert.IsTrue(machine.Banknotes.ContainsKey(Banknotes.Fifty));
        }

        [TestMethod]
        public void FillWithMoney_OnlyBanknotes_Success()
        {
            //Arrange
            Machine machine = new Machine();
            Dictionary<Banknotes, int> banknotes = new Dictionary<Banknotes, int>()
            {
                { Banknotes.Fifty, 5 },
                { Banknotes.FiveHudreds, 5 }
            };

            //Act
            machine.FillWithMoney(banknotes, null);

            //Assert
            Assert.AreEqual(2, machine.Banknotes.Count);
            Assert.IsTrue(machine.Banknotes.ContainsKey(Banknotes.Fifty));
        }

        [TestMethod]
        public void FillWithMoney_OnlyCoins_Success()
        {
            //Arrange
            Machine machine = new Machine();
            Dictionary<Coins, int> coins = new Dictionary<Coins, int>()
            {
                { Coins.Five, 5 },
                { Coins.One, 5 }
            };

            //Act
            machine.FillWithMoney(null, coins);

            //Assert
            Assert.AreEqual(2, machine.Coins.Count);
            Assert.IsTrue(machine.Coins.ContainsKey(Coins.Five));
        }

        [TestMethod]
        public void FillWithMoney_WithoutMoney_Throws()
        {
            //Arrange
            Machine machine = new Machine();
            Dictionary<Banknotes, int> banknotes = new Dictionary<Banknotes, int>()
            {
            };
            Dictionary<Coins, int> coins = new Dictionary<Coins, int>()
            {
            };

            //Act and Assert
            Assert.ThrowsException<ArgumentException>(() => machine.FillWithMoney(banknotes, coins));
        }
    }
}
