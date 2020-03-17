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
        public void CarListAndCountOk()
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
            TestItem.RegPlate = "dy20abc";
            TestItem.CarName = "Audi";
            TestItem.CarModel = "S5";
            TestItem.CarColour = "Blue";
            TestItem.EngineSize = "2949";
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

        [TestMethod]
        public void UpdateMethodOk()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create the item of test data
            clsCar TestItem = new clsCar();
            //var to store the prim key
            Int32 PrimaryKey = 0;
            //set its proprties 
            TestItem.RegPlate = "dy20abc";
            TestItem.CarName = "Audi";
            TestItem.CarModel = "S5";
            TestItem.CarColour = "Blue";
            TestItem.EngineSize = "2949cc";
            TestItem.Price = 150;
            //set this cars to the test data
            AllCars.ThisCar = TestItem;
            //+ the record
            PrimaryKey = AllCars.Add();
            //modify the test data 
            TestItem.RegPlate = "kl98ght";
            TestItem.CarName = "Audj";
            TestItem.CarModel = "q5";
            TestItem.CarColour = "Black";
            TestItem.EngineSize = "3000cc";
            TestItem.Price = 150;
            //set the record based on the new test data
            AllCars.ThisCar = TestItem;
            //update the record
            AllCars.Update();
            //find the record 
            AllCars.ThisCar.Find(PrimaryKey);
            //test to see that the 2 values are the same 
            Assert.AreEqual(AllCars.ThisCar, TestItem);
        }

        [TestMethod]
        public void ReportByRegPlateMethodOk()
        {
            //create an instance of the class containg unfiltered results
            clsCarCollection AllCars = new clsCarCollection();
            //create an instance of the filtere data
            clsCarCollection FilteredCars = new clsCarCollection();
            //apply a blank string (should return all records)
            FilteredCars.ReportByRegPlate("");
            //test to see that the 2 values are the same
            Assert.AreEqual(AllCars.Count, FilteredCars.Count);
        }

        [TestMethod]
        public void ReportByRegPlateNoneFound()
        {
            //create an instance of the filtered data
            clsCarCollection FilteredCars = new clsCarCollection();
            //apply a post code that doesnt exist
            FilteredCars.ReportByRegPlate("xxxx xxx");
            Assert.AreEqual(0, FilteredCars.Count);
        }

        [TestMethod]
        public void ReportByRegPlateTestDataFound()
        {
            //create an instance of the filtered data
            clsCarCollection FilteredCars = new clsCarCollection();
            //var to sore outcome
            Boolean Ok = true;
            //apply a reg plate that doesnt exist
            FilteredCars.ReportByRegPlate("cd18hju");
            //check that the correct no of records are found 
            if (FilteredCars.Count == 2)
            {
                //check that the first record is ID 4
                if (FilteredCars.CarList[0].CarID != 3)
                {
                    Ok = false;
                }
                //check that the first reocrd is ID 5
                if (FilteredCars.CarList[1].CarID != 20)
                {
                    Ok = false;
                }
            }
            else
            {
                Ok = false;
            }
            //test to see that there are no records
            Assert.IsTrue(Ok);
        }

        
    }
}
