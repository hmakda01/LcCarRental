using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalClasses
{
    public class clsCar
    {
        private Int32 mCarID;
        private string mCarName;
        private string mRegPlate;
        private string mCarModel;
        private string mCarColour;
        private string mEngineSize;
        private Int32 mPrice;

        public string CarName
        {
            get
            {
                return mCarName;
            }
            set
            {
                mCarName = value;
            }
        }

        public string CarColour
        {
            get
            {
                return mCarColour;
            }
            set
            {
                mCarColour = value;
            }
        }

        public string RegPlate
        {
            get
            {
                return mRegPlate;
            }
            set
            {
                mRegPlate = value;
            }
        }

        public string CarModel
        {
            get
            {
                return mCarModel;
            }
            set
            {
                mCarModel = value;
            }
        }

        public string EngineSize
        {
            get
            {
                return mEngineSize;
            }
            set
            {
                mEngineSize = value;
            }
        }

        public int Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        public string Valid(string regPlate, string carName, string carModel, string carColor, string enginesize, string price)
        {
            //create a string variable to store the error
            String Error = "";
            //if the CarReg is blak
            if (regPlate.Length == 0)
            {
                //record the err
                Error = Error + "The Car Reg may not be blank";
            }
            if (regPlate.Length > 7)
            {
                Error = Error + "The Car Reg must not be more than 6 characters";
            }
            if (carName.Length == 0)
            {
                //record the err
                Error = Error + "The Car Name may not be blank";
            }
            if (carName.Length > 15)
            {
                Error = Error + "The Car Name must not be more than 15 characters";
            }
            if (CarModel.Length == 0)
            {
                //record the err
                Error = Error + "The Car model may not be blank";
            }
            if (CarModel.Length > 15)
            {
                Error = Error + "The Car model must not be more than 15 characters";
            }
            if (CarColour.Length == 0)
            {
                //record the err
                Error = Error + "The Car colour may not be blank";
            }
            if (CarColour.Length > 10)
            {
                Error = Error + "The Car colour must not be more than 10 characters";
            }
            if (EngineSize.Length == 0)
            {
                //record the err
                Error = Error + "The Car Engine Size may not be blank";
            }
            if (EngineSize.Length > 4)
            {
                Error = Error + "The Car Engine Size must not be more than 4 characters";
            }
            if (price.Length == 0)
            {
                //record the err
                Error = Error + "The Car price may not be blank";
            }
            if (price.Length > 4)
            {
                Error = Error + "The Car price must not be more than 4 characters";
            }
            //return any error essage
            return Error;
        }

        public int CarID
        {
            get
            {
                return mCarID;
            }
            set
            {
                mCarID = value;
            }
        }

     

        public bool Find(int CarID)
        {
            //create an instance of daa conection
            clsDataConnection DB = new clsDataConnection();
            //add the paramter for the car id to searc for
            DB.AddParameter("@CarID", CarID);
            //execute the storted procedure
            DB.Execute("sproc_tblCars_FilterByCarID");
            //if one record is fond 
            if (DB.Count == 1)
            {
                //copy the data from the db tothe private data memebers
                mCarID = Convert.ToInt32(DB.DataTable.Rows[0]["CarID"]);
                mRegPlate = Convert.ToString(DB.DataTable.Rows[0]["RegPlate"]);
                mCarName = Convert.ToString(DB.DataTable.Rows[0]["CarName"]);
                mCarModel = Convert.ToString(DB.DataTable.Rows[0]["CarModel"]);
                mCarColour = Convert.ToString(DB.DataTable.Rows[0]["CarColour"]);
                mEngineSize = Convert.ToString(DB.DataTable.Rows[0]["EngineSize"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}