using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MISIS.OOAD.COMMON;
using MISIS.OOAD.COMMON.Foods;

namespace MISIS.OOAD.UnitTests
{
    [TestClass]
    public class LoadFoodsTests
    {
        [TestMethod]
        public void LoadFoods_Success()
        {
            //Arrange
            TestFood instance = new TestFood(0, "123");
            Machine machine = new Machine();

            //Act
            machine.Load(instance);

            //Assert
            Assert.IsInstanceOfType(machine.Foods, typeof(List<FoodBase>));
            var instances = machine.Foods as List<FoodBase>;
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
                new TestFood(0, "123"), new TestFood(0, "123")
            };

            Machine machine = new Machine();

            //Act
            machine.Load(instances);

            //Assert
            Assert.IsInstanceOfType(machine.Foods, typeof(List<FoodBase>));
            var instancesResult = machine.Foods as List<FoodBase>;
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
