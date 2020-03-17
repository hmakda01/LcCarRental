using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalClasses
{
    public class clsCar
    {
        private Int32 mCarID;
        private String mRegPlate;
        private String mCarName;
        private String mCarModel;
        private String mCarColour;
        private String mEngineSize;
        private Int32 mPrice;



        public int CarID
        {
            get
            {
                return mCarID;
            }

            set
            {
                //set the value of the data private data meber
                mCarID = value;
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

        public string Valid(string RegPlate, string carName, string carModel, string carColor, string engineSize, string price)
        {
            //create a string variable to store the error
            String Error = "";
            //if the CarReg is blak
            if (RegPlate.Length == 0)
            {
                //record the err
                Error = Error + "The Car Reg may not be blank";
            }
            if (RegPlate.Length > 50)
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
            if (carModel.Length == 0)
            {
                //record the err
                Error = Error + "The Car model may not be blank";
            }
            if (carModel.Length > 15)
            {
                Error = Error + "The Car model must not be more than 15 characters";
            }
            if (carColor.Length == 0)
            {
                //record the err
                Error = Error + "The Car colour may not be blank";
            }
            if (carColor.Length > 10)
            {
                Error = Error + "The Car colour must not be more than 10 characters";
            }
            if (engineSize.Length == 0)
            {
                //record the err
                Error = Error + "The Car Engine Size may not be blank";
            }
            if (engineSize.Length > 6)
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
