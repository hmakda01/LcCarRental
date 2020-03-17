﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalClasses;

public partial class CustomerDelete : System.Web.UI.Page
{
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session[CustomerID]);
    }

    void DeleteCustomer()
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CustomerID);
        CustomerBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeleteCustomer();
        Response.Redirect("CustomerList.aspx");
    }
}