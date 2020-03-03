using System;
using CarRentalClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRentalTest
{
    [TestClass]
    public class tstAddCar
    {
     
        [TestMethod]
        public void InstanceOk()
        {
            //Create an instanceof the class we want to create
            clsCar AnCar = new clsCar();
            //test to see that it exists
            Assert.IsNotNull(AnCar);

        }
     




        [TestMethod]
        public void CarNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCar AnCarName = new clsCar();
            //create some test data to assign to the property
            string TestData = "BMW";
            //assign the data to the property
            AnCarName.CarName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCarName.CarName, TestData);
        }

        [TestMethod]
        public void CarColourPropertyOK()
        {
            //create an instance of the class we want to create
            clsCar AnCarColour = new clsCar();
            //create some test data to assign to the property
            string TestData = "black";
            //assign the data to the property
            AnCarColour.CarColour = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCarColour.CarColour, TestData);
        }

        [TestMethod]
        public void CarModelPropertyOk()
        {
            //create an instance of the class we want to create
            clsCar AnCarModel = new clsCar();
            //create some test data to assign to the property
            string TestData = "RS7";
            //assign the data to the property
            AnCarModel.CarModel = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCarModel.CarModel, TestData);
        }

        [TestMethod]
        public void RegPlatePropertyOk()
        {
            //create an instance of the class we want to create
            clsCar AnRegPlate = new clsCar();
            //create some test data to assign to the property
            string TestData = "AB69BNM";
            //assign the data to the property
            AnRegPlate.RegPlate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnRegPlate.RegPlate, TestData);
        }

        [TestMethod]
        public void EnginesizePropertyOk()
        {
            //create an instance of the class we want to create
            clsCar AnEngineSize = new clsCar();
            //create some test data to assign to the property
            string TestData = "2999";
            //assign the data to the property
            AnEngineSize.EngineSize = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEngineSize.EngineSize, TestData);
        }

        [TestMethod]
        public void PricePropertyOk()
        {
            //create an instance of the class we want to create
            clsCar AnPrice = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 5;
            //assign the data to the property
            AnPrice.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPrice.Price, TestData);
        }

        [TestMethod]
        public void CarIDPropertyOk()
        {
            //create an instance of the class we want to create
            clsCar AnCarId = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCarId.CarID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCarId.CarID, TestData);
        }

    }
}