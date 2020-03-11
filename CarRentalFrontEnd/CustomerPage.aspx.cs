﻿using CarRentalClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        ACustomer.CustomerFirstName = txtFirstName.Text;
        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerPageViewer.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["AddressNo"] = -1;
        Response.Redirect("CustomerPage.aspx");
    }
}