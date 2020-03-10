using System.Collections.Generic;
using System;

namespace CarRentalClasses
{
    public class clsCustomerCollection
    {
       
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        clsCustomer mThisCustomer = new clsCustomer();

        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
            DB.AddParameter("@CustomerLastName", mThisCustomer.CustomerLastName);
            DB.AddParameter("@Username", mThisCustomer.Username);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerTelephone", mThisCustomer.CustomerTelephone);
            DB.AddParameter("@CustomerHouseNo", mThisCustomer.CustomerHouseNo);
            DB.AddParameter("@CustomerPostCode", mThisCustomer.CustomerPostCode);
            DB.AddParameter("@CustomerStreet", mThisCustomer.CustomerStreet);
            DB.AddParameter("@CustomerTown", mThisCustomer.CustomerTown);
            DB.AddParameter("@Active", mThisCustomer.Active);
            return DB.Execute("sproc_tblCustomer_Insert");
            //lab 21 page 7
            //lab 21 page 7
            //lab 21 page 7
            //lab 21 page 7
            //lab 21 page 7
            //lab 21 page 7
            //lab 21 page 7
            //lab 21 page 7

        }

        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }

        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                //
            }
        }



        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblAddress_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ACustomer.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.CustomerLastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.CustomerTelephone = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                ACustomer.CustomerHouseNo = Convert.ToInt32(DB.DataTable.Rows[Index]["HouseNo"]);
                ACustomer.CustomerPostCode = Convert.ToString(DB.DataTable.Rows[Index]["Postcode"]);
                ACustomer.CustomerStreet = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                ACustomer.CustomerTown = Convert.ToString(DB.DataTable.Rows[Index]["Town"]);

                mCustomerList.Add(ACustomer);
                Index++;
            }
        }
    }
}