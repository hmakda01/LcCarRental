using System.Collections.Generic;
using System;

namespace CarRentalClasses
{
    public class clsCarCollection
    {
        //private data memebr for the list
        List<clsCar> mCarList = new List<clsCar>();
        //private data member thiscar
        clsCar mThisCar = new clsCar();

        //public property for the car list
        public List<clsCar> CarList
        {
            get
            {
                //return the private data 
                return mCarList;
            }
            set
            {
                //set the private data 
                mCarList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCarList.Count;
            }
            set
            {
                
            }
        }

        //public property for thiscar
        public clsCar ThisCar
        {
            get
            {
                //return the priv data
                return mThisCar;
            }
            set
            {
                //set the private data
                mThisCar = value;
            }
        }

        //constructor for the class
        public clsCarCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute this storted procedure
            DB.Execute("sproc_tblCars_Selectall");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        

        public int Add()
        {
            //add new record to database based on the value of thiscar
            //connect 2 db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CarID", mThisCar.CarID);
            DB.AddParameter("@RegPlate", mThisCar.RegPlate);
            DB.AddParameter("@CarName", mThisCar.CarName);
            DB.AddParameter("@CarModel", mThisCar.CarModel);
            DB.AddParameter("@CarColour", mThisCar.CarColour);
            DB.AddParameter("@EngineSize", mThisCar.EngineSize);
            DB.AddParameter("@Price", mThisCar.Price);
            return DB.Execute("sproc_tblCars_SelectAll");
        }

        public void Delete()
        {
            //delete the record pointed to by thiscars
            //connect to DB
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for record procedure
            DB.AddParameter("@CarID", mThisCar.CarID);
            //execute the stored procedure
            DB.Execute("sproc_tblCars_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thiscars
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the storted procedures 
            DB.AddParameter("@CarID", mThisCar.CarID);
            DB.AddParameter("@RegPlate", mThisCar.RegPlate);
            DB.AddParameter("@CarName", mThisCar.CarName);
            DB.AddParameter("@CarModel", mThisCar.CarModel);
            DB.AddParameter("@CarColour", mThisCar.CarColour);
            DB.AddParameter("@EngineSize", mThisCar.EngineSize);
            DB.AddParameter("@Price", mThisCar.Price);
            DB.Execute("sproc_tblCars_Update");
        }

        public void ReportByRegPlate(string RegPlate)
        {
            //filter the record based on a full reg plate
            //connect to DB
            clsDataConnection DB = new clsDataConnection();
            //send the postcode parameter to the DB
            DB.AddParameter("@RegPlate", RegPlate);
            //execute the stored procedure 
            DB.Execute("sproc_tblCars_FilterByRegPlate");
            //populate the array list with the data table
            PopulateArray(DB);
        }



        void PopulateArray(clsDataConnection DB)
        {
            //pipulates the arry list based on the data tbale in the param DB
            //var for the index
            Int32 Index = 0;
            //var to store to record court
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCarList = new List<clsCar>();
            //while three are records to process
            while (Index < RecordCount)
            {
                //create a blank car
                clsCar AnCar = new clsCar();
                //read in the fields from the current record
                AnCar.CarID = Convert.ToInt32(DB.DataTable.Rows[Index]["CarID"]);
                AnCar.RegPlate = Convert.ToString(DB.DataTable.Rows[Index]["RegPlate"]);
                AnCar.CarName = Convert.ToString(DB.DataTable.Rows[Index]["CarName"]);
                AnCar.CarModel = Convert.ToString(DB.DataTable.Rows[Index]["CarModel"]);
                AnCar.CarColour = Convert.ToString(DB.DataTable.Rows[Index]["CarColour"]);
                AnCar.EngineSize = Convert.ToString(DB.DataTable.Rows[Index]["EngineSize"]);
                AnCar.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                //dd the record to the private data number
                mCarList.Add(AnCar);
                //point at the next record
                Index++;
            }
        }

    }
}