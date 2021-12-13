using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MISIS.OOAD.COMMON;

namespace MISIS.OOAD.UnitTests
{
    [TestClass]
    public class LoadFoodsTests
    {
        [TestMethod]
        public void LoadFoods_Success()
        {
            //Arrange
            TestFood instance = new TestFood();
            Machine machine = new Machine();

            //Act
            machine.Load(instance);

            //Assert
            Assert.IsInstanceOfType(machine.Foods, typeof(List<Food>));
            var instances = machine.Foods as List<Food>;
            Assert.AreEqual(1, instances.Count);
        }

        [TestMethod]
        public void LoadFoods_ArgumentNull_FoodIsNull()
        {
            //Arrange
            TestFood instance = null;
            Machine machine = new Machine();

            //Act and assert
            Assert.ThrowsException<ArgumentNullException>(() => machine.Load(instance));
        }

        [TestMethod]
        public void LoadFoodsMultiplie_Success()
        {
            //Arrange
            TestFood[] instances = new TestFood[2]
            {
                new TestFood{ Name="1"}, new TestFood{ Name="2"}
            };

            Machine machine = new Machine();

            //Act
            machine.Load(instances);

            //Assert
            Assert.IsInstanceOfType(machine.Foods, typeof(List<Food>));
            var instancesResult = machine.Foods as List<Food>;
            Assert.AreEqual(2, instancesResult.Count);
        }

        [TestMethod]
        public void LoadFoodsMultiplie_ArgumentNull_FoodIsNull()
        {
            //Arrange
            TestFood[] instances = null;
            Machine machine = new Machine();

            //Act and assert
            var exception = Assert.ThrowsException<ArgumentNullException>(() => machine.Load(instances));
            Assert.AreEqual("foods", exception.ParamName);
        }

        [TestMethod]
        public void LoadFoodsMultiplie_Argument_FoodIsEmpty()
        {
            //Arrange
            TestFood[] instances = new TestFood[0];
            Machine machine = new Machine();

            //Act and assert
            var exception = Assert.ThrowsException<ArgumentException>(() => machine.Load(instances));
            Assert.AreEqual("foods", exception.ParamName);
        }
    }
}
