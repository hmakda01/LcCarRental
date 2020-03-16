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
            DB.AddParameter("@Username", mThisCustomer.Username);
            DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
            DB.AddParameter("@CustomerLastName", mThisCustomer.CustomerLastName);
            DB.AddParameter("@CustomerTelephone", mThisCustomer.CustomerTelephone);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@Active", mThisCustomer.Active);
            return DB.Execute("sproc_tblCustomer_Insert");
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
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ACustomer.Username = Convert.ToString(DB.DataTable.Rows[Index]["Username"]);
                ACustomer.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.CustomerLastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.CustomerTelephone = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
               
                mCustomerList.Add(ACustomer);
                Index++;
            }
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.Execute("sproc_tblCustomer_Delete");
        }
    }
}