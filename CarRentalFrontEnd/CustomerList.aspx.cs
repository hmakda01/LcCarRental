using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalClasses;

public partial class CustomerList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        lstCustomer.DataSource = Customer.CustomerList;
        lstCustomer.DataValueField = "CustomerID";
        lstCustomer.DataTextField = "Username";
        lstCustomer.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerID"] = -1;
        Response.Redirect("CustomerPage.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;
        if (lstCustomer.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomer.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("CustomerDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;
        if (lstCustomer.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomer.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("CustomerPage.aspx");
        }
        else
        {
            lblError.Text = "please select a record to edit from the list";
        }
    }
}