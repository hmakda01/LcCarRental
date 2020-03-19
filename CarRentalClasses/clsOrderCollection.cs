using System.Collections.Generic;
using System;

namespace CarRentalClasses
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }

            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

                //we shall worry about this later
            }







        }

        public clsOrder ThisOrder
        {

            get
            {

                return mThisOrder;
            }
            set
            {
                mThisOrder = value;

            }


        }

        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
           // DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@StaffID", mThisOrder.StaffID);
            DB.AddParameter("@CarID", mThisOrder.CarID);
            DB.AddParameter("@Date", mThisOrder.Date);
            DB.AddParameter("@Email", mThisOrder.Email);
            DB.AddParameter("@Price", mThisOrder.Price);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");



        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@StaffID", mThisOrder.StaffID);
            DB.AddParameter("@CarID", mThisOrder.CarID);
            DB.AddParameter("@Date", mThisOrder.Date);
            DB.AddParameter("@Email", mThisOrder.Email);
            DB.AddParameter("@Price", mThisOrder.Price);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblOrder_Update");

        }

        public void ReportByEmail(string Email)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Email", Email);
            DB.Execute("sproc_tblOrder_FilterByEmail");
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter    }
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnOrder.CarID = Convert.ToInt32(DB.DataTable.Rows[Index]["CarID"]);
                AnOrder.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                AnOrder.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnOrder.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }
    }











}


