using System;
using CarRentalClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRentalTest
{
    [TestClass]
    public class tstAddCar
    {
        string RegPlate = "as23 vfd";
        string CarName = "bmw";
        string CarModel = "1s";
        string CarColour = "Black";
        string EngineSize = "2541";
        string Price = "1";

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

        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance og the class we want to create
            clsCar AnCar = new clsCar();
            //boolean variable to store the result of the valdation 
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CarID = 21;
            //invoke the method
            Found = AnCar.Find(CarID);
            //test to see that the result is correct 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCarIDFound()
        {
            //create an instnace of the class we want to create 
            clsCar AnCar = new clsCar();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean vairble to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 CarID = 21;
            //invoke the method 
            Found = AnCar.Find(CarID);
            //check the car id
            if (AnCar.CarID != 21)
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestRegPlateFound()
        {
            //create an instnace of the class we want to create 
            clsCar AnCar = new clsCar();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean vairble to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 CarID = 22;
            //invoke the method 
            Found = AnCar.Find(CarID);
            //check the car id
            if (AnCar.RegPlate != "cc12bvcx")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestCarNameFound()
        {
            //create an instnace of the class we want to create 
            clsCar AnCar = new clsCar();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean vairble to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 CarID = 21;
            //invoke the method 
            Found = AnCar.Find(CarID);
            //check the car id
            if (AnCar.CarName != "test")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestCarModelFound()
        {
            //create an instnace of the class we want to create 
            clsCar AnCar = new clsCar();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean vairble to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 CarID = 21;
            //invoke the method 
            Found = AnCar.Find(CarID);
            //check the car id
            if (AnCar.CarModel != "test")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestCarColourFound()
        {
            //create an instnace of the class we want to create 
            clsCar AnCar = new clsCar();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean vairble to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 CarID = 21;
            //invoke the method 
            Found = AnCar.Find(CarID);
            //check the car id
            if (AnCar.CarColour != "black")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestEngineSizeFound()
        {
            //create an instnace of the class we want to create 
            clsCar AnCar = new clsCar();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean vairble to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 CarID = 21;
            //invoke the method 
            Found = AnCar.Find(CarID);
            //check the car id
            if (AnCar.EngineSize != "50000")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instnace of the class we want to create 
            clsCar AnCar = new clsCar();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean vairble to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 CarID = 21;
            //invoke the method 
            Found = AnCar.Find(CarID);
            //check the car id
            if (AnCar.Price != 4576)
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void RegPlateMin()
        {
            //create an instance of the class we want to create
            clsCar AnRegPlate = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RegPlate = "BMW"; //this should be ok
            //invoke the method
            Error = AnRegPlate.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RegPlateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCar AnRegPlate = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RegPlate = "aass"; //this should be ok
            //invoke the method
            Error = AnRegPlate.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RegPlateMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCar AnRegPlate = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RegPlate = "kl12hn"; //this should be ok
            //invoke the method
            Error = AnRegPlate.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RegPlateMax()
        {
            //create an instance of the class we want to create
            clsCar AnRegPlate = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RegPlate = "kfdsert"; //this should be ok
            //invoke the method
            Error = AnRegPlate.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RegPlateMid()
        {
            //create an instance of the class we want to create
            clsCar AnRegPlate = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RegPlate = "aaa"; //this should be ok
            //invoke the method
            Error = AnRegPlate.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RegPlateMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCar AnRegPlate = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RegPlate = "dddddddd"; //this should be ok
            //invoke the method
            Error = AnRegPlate.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
      
        [TestMethod]
        public void RegPlateExtremeMax()
        {
            //create an instance of the class we want to create
            clsCar AnRegPlate = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RegPlate = "";
            //this should be ok
            RegPlate = RegPlate.PadRight(500, 'a');
            //invoke the method
            Error = AnRegPlate.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarNameMin()
        {
            //create an instance of the class we want to create
            clsCar AnCarName = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarName = "BMW"; //this should be ok
            //invoke the method
            Error = AnCarName.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCar AnCarName = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarName = "bmwq"; //this should be ok
            //invoke the method
            Error = AnCarName.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCar AnCarName = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarName = "iiiiiiiiiiiiii"; //this should be ok
            //invoke the method
            Error = AnCarName.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarNameMax()
        {
            //create an instance of the class we want to create
            clsCar AnCarName = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarName = "auuuuuuuuuuuuuu"; //this should be ok
            //invoke the method
            Error = AnCarName.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarNameMid()
        {
            //create an instance of the class we want to create
            clsCar AnCarName = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarName = "lkjhgfrt"; //this should be ok
            //invoke the method
            Error = AnCarName.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
     
        [TestMethod]
        public void CarNameMaxplusOne()
        {
            //create an instance of the class we want to create
            clsCar AnCarName = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarName = "bbbbbbbbbbbbbbbb"; //this should be ok
            //invoke the method
            Error = AnCarName.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CarNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCar AnCarName = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarName = "";
            //this should be ok
            CarName = CarName.PadRight(500, 'a');
            //invoke the method
            Error = AnCarName.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMin()
        {
            //create an instance of the class we want to create
            clsCar AnCarModel = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarModel = "aclass"; //this should be ok
            //invoke the method
            Error = AnCarModel.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCar AnCarModel = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarModel = "b"; //this should be ok
            //invoke the method
            Error = AnCarModel.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarModelMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCar AnCarModel = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarModel = "aslandroverasd"; //this should be ok
            //invoke the method
            Error = AnCarModel.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarModelMax()
        {
            //create an instance of the class we want to create
            clsCar AnCarModel = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarModel = "aslandroverasdg"; //this should be ok
            //invoke the method
            Error = AnCarModel.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMid()
        {
            //create an instance of the class we want to create
            clsCar AnCarModel = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarModel = "lkjhgfrt"; //this should be ok
            //invoke the method
            Error = AnCarModel.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarModelMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCar AnCarModel = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarModel = "";
            //this should be ok
            CarModel = CarModel.PadRight(500, 'a');
            //invoke the method
            Error = AnCarModel.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
       
        [TestMethod]
        public void CarModelExtremeMax()
        {
            //create an instance of the class we want to create
            clsCar AnCarModel = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarModel = "";
            //this should be ok
            CarModel = CarModel.PadRight(500, 'a');
            //invoke the method
            Error = AnCarModel.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CarColourMin()
        {
            //create an instance of the class we want to create
            clsCar AnCarColour = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarColour = "red"; //this should be ok
            //invoke the method
            Error = AnCarColour.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarColourMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCar AnCarColour = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarColour = "re"; //this should be ok
            //invoke the method
            Error = AnCarColour.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarColourMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCar AnCarColour = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarColour = "blueredwh"; //this should be ok
            //invoke the method
            Error = AnCarColour.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarColourMax()
        {
            //create an instance of the class we want to create
            clsCar AnCarColour = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarColour = "blueredwhi"; //this should be ok
            //invoke the method
            Error = AnCarColour.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarColourMid()
        {
            //create an instance of the class we want to create
            clsCar AnCarColour = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarColour = "lkjhgfrt"; //this should be ok
            //invoke the method
            Error = AnCarColour.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
       
        
        [TestMethod]
        public void CarColourMaxplusOne()
        {
            //create an instance of the class we want to create
            clsCar AnCarColour = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarColour = "";
            //this should be ok
            CarColour = CarColour.PadRight(500, 'a');
            //invoke the method
            Error = AnCarColour.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CarColourExtremeMax()
        {
            //create an instance of the class we want to create
            clsCar AnCarColour = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarColour = "";
            //this should be ok
            CarColour = CarColour.PadRight(500, 'a');
            //invoke the method
            Error = AnCarColour.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EngineSizeMin()
        {
            //create an instance of the class we want to create
            clsCar AnEngineSize = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EngineSize = "452"; //this should be ok
            //invoke the method
            Error = AnEngineSize.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EngineSizeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCar AnEngineSize = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EngineSize = "12"; //this should be ok
            //invoke the method
            Error = AnEngineSize.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EngineSizeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCar AnEngineSize = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EngineSize = "156"; //this should be ok
            //invoke the method
            Error = AnEngineSize.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EngineSizeMax()
        {
            //create an instance of the class we want to create
            clsCar AnEngineSize = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EngineSize = "4587"; //this should be ok
            //invoke the method
            Error = AnEngineSize.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EngineSizeMid()
        {
            //create an instance of the class we want to create
            clsCar AnEngineSize = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EngineSize = "2000"; //this should be ok
            //invoke the method
            Error = AnEngineSize.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
      

        [TestMethod]
        public void EngineSizeMaxplusOne()
        {
            //create an instance of the class we want to create
            clsCar AnEngineSize = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EngineSize = "";
            //this should be ok
            EngineSize = EngineSize.PadRight(500, 'a');
            //invoke the method
            Error = AnEngineSize.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EngineSizeExtremeMax()
        {
            //create an instance of the class we want to create
            clsCar AnEngineSize = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EngineSize = "";
            //this should be ok
            EngineSize = EngineSize.PadRight(500, 'a');
            //invoke the method
            Error = AnEngineSize.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsCar AnPrice = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "90"; //this should be ok
            //invoke the method
            Error = AnPrice.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCar AnPrice = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "1"; //this should be ok
            //invoke the method
            Error = AnPrice.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCar AnPrice = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "156"; //this should be ok
            //invoke the method
            Error = AnPrice.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsCar AnPrice = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "4587"; //this should be ok
            //invoke the method
            Error = AnPrice.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsCar AnPrice = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "2000"; //this should be ok
            //invoke the method
            Error = AnPrice.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCar AnPrice = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "";
            //this should be ok
            Price = Price.PadRight(500, '1');
            //invoke the method
            Error = AnPrice.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsCar AnPrice = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "";
            //this should be ok
            Price = Price.PadRight(500, '1');
            //invoke the method
            Error = AnPrice.Valid(RegPlate, CarName, CarModel, CarColour, EngineSize, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}