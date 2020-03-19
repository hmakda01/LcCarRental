using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalClasses;
public partial class Order : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            DisplayOrders();
            if (OrderID != -1)
            {
                DisplayOrders();
            }
        }
    }

    private void DisplayOrders()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderID);
        
        TxtbCustomerID.Text = OrderBook.ThisOrder.CustomerID.ToString();
        txtbStaffID.Text = OrderBook.ThisOrder.StaffID.ToString();
        TxtBCarID.Text = OrderBook.ThisOrder.CarID.ToString();
        TxtBDate.Text = OrderBook.ThisOrder.Date.ToString();
        TxtBEmail.Text = OrderBook.ThisOrder.Email;
        TxtBPrice.Text = OrderBook.ThisOrder.Price.ToString();

    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        //add the new record
       if (OrderID == -1)
       {


            Add();
        }
       else
        {
            Update();
        }
    }

    void Add()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        String Error = OrderBook.ThisOrder.Valid(TxtBDate.Text, TxtBEmail.Text, TxtBPrice.Text);
        if (Error == "")
        {
          
            OrderBook.ThisOrder.CustomerID = Convert.ToInt32(TxtbCustomerID);
            OrderBook.ThisOrder.StaffID = Convert.ToInt32(txtbStaffID);
            OrderBook.ThisOrder.CarID = Convert.ToInt32(TxtBCarID);
            OrderBook.ThisOrder.Date = Convert.ToDateTime(TxtBDate);
            OrderBook.ThisOrder.Email = TxtBEmail.Text;
            OrderBook.ThisOrder.Price = Convert.ToInt32(TxtBPrice);
            OrderBook.Add();
        }
        else
        {
            //report an error
            LblError.Text = "There was a problem with the data that has been entered" + Error;
        }
    }
        void Update()
        {
            clsOrderCollection OrderBook = new clsOrderCollection();
            String Error = OrderBook.ThisOrder.Valid(TxtBDate.Text, TxtBEmail.Text, TxtBPrice.Text);
            if (Error == "")
            {
           // OrderBook.ThisOrder.Find(OrderID);
               
                OrderBook.ThisOrder.CustomerID = Convert.ToInt32(TxtbCustomerID);
                OrderBook.ThisOrder.StaffID = Convert.ToInt32(txtbStaffID);
                OrderBook.ThisOrder.CarID = Convert.ToInt32(TxtBCarID);
                OrderBook.ThisOrder.Date = Convert.ToDateTime(TxtBDate);
                OrderBook.ThisOrder.Email = TxtBEmail.Text;
                OrderBook.ThisOrder.Price = Convert.ToInt32(TxtBPrice);
                OrderBook.update();
                Response.Redirect("Order.aspx");
            }
            else
            {
                //report an error
                LblError.Text = "There was a problem with the data that has been entered" + Error;
            }


        }


    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}





