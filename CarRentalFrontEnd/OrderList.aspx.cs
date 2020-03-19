using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalClasses;

public partial class OrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrder();
        }
    }

    protected void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    void DisplayOrder()
    {
        clsOrderCollection Order = new clsOrderCollection();
        lstOrder.DataSource = Order.OrderList;
        lstOrder.DataValueField = "OrderID";
        lstOrder.DataTextField = "StaffID";
        lstOrder.DataBind();
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;
        Response.Redirect("Order.aspx");
    }







    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrder.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrder.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("OrderDelete.aspx");
        }
        else // if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";



        }

        }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrder.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrder.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("Order.aspx");
        }

        else
        {
            lblError.Text = "Please select a record to delete from the list";
        
        }

        }

    protected void BtnApply_Click(object sender, EventArgs e)
    {

    }
}

