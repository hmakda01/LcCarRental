using System;
using CarRentalClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CarRentalTest
{
    [TestClass]
    public class tstCarCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCars);
        }

        [TestMethod]
        public void CarListOk()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCar> Testlist = new List<clsCar>();
            //add an item to the list
            //create the item of test data
            clsCar TestItem = new clsCar();
            //set its proprties 
            TestItem.CarID = 1;
            TestItem.RegPlate = "dy20abc";
            TestItem.CarName = "Audi";
            TestItem.CarModel = "S5";
            TestItem.CarColour = "Blue";
            TestItem.EngineSize = "2949cc";
            TestItem.Price = 150;
            //add the item to the test list 
            Testlist.Add(TestItem);
            //assign the data to the property
            AllCars.CarList = Testlist;
            //test to see that the two values are the samw
            Assert.AreEqual(AllCars.CarList, Testlist);
        }

       

        [TestMethod]
        public void ThisCarPropertyOk()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create some test data to assign to the property
            clsCar TestCar = new clsCar();
            //set its proprties 
            TestCar.CarID = 1;
            TestCar.RegPlate = "dy20abc";
            TestCar.CarName = "Audi";
            TestCar.CarModel = "S5";
            TestCar.CarColour = "Blue";
            TestCar.EngineSize = "2949cc";
            TestCar.Price = 150;
            //assign the data to the property
            AllCars.ThisCar = TestCar;
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.ThisCar, TestCar);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create the item of test data
            clsCar TestItem = new clsCar();
            //var to store the prim key
            Int32 PrimaryKey = 0;
            //set its proprties 
            TestItem.CarID = 10;
            TestItem.RegPlate = "dy20abc";
            TestItem.CarName = "Audi";
            TestItem.CarModel = "S5";
            TestItem.CarColour = "Blue";
            TestItem.EngineSize = "2949cc";
            TestItem.Price = 150;
            //set this cars to the test data
            AllCars.ThisCar = TestItem;
            //add record
            PrimaryKey = AllCars.Add();
            //set the prim key of the test data
            TestItem.CarID = PrimaryKey;
            //find the record 
            AllCars.ThisCar.Find(PrimaryKey);
            //test to see that the 2 values are the same 
            Assert.AreEqual(AllCars.ThisCar, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create the item of test data
            clsCar TestItem = new clsCar();
            //var to store the prim key
            Int32 PrimaryKey = 0;
            //set its proprties 
            TestItem.CarID = 10;
            TestItem.RegPlate = "dy20abc";
            TestItem.CarName = "Audi";
            TestItem.CarModel = "S5";
            TestItem.CarColour = "Blue";
            TestItem.EngineSize = "2949cc";
            TestItem.Price = 150;
            //set this cars to the test data
            AllCars.ThisCar = TestItem;
            //add record
            PrimaryKey = AllCars.Add();
            //set the prim key of the test data
            TestItem.CarID = PrimaryKey;
            //find the record 
            AllCars.ThisCar.Find(PrimaryKey);
            //delte record
            AllCars.Delete();
            //find record
            Boolean Found = AllCars.ThisCar.Find(PrimaryKey);
            //test to see recrod not found
            Assert.IsFalse(Found);
        }
    }
}
