using CarRentalClasses;
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
        //clsCustomer ACustomer = new clsCustomer();
        //ACustomer.CustomerFirstName = txtFirstName.Text;
        //Session["ACustomer"] = ACustomer;
        //Response.Redirect("CustomerPageViewer.aspx");

        Add();
        Response.Redirect("CustomerPage.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerID"] = -1;
        Response.Redirect("CustomerPage.aspx");
    }

    void Add()
    {
        clsCustomerCollection customerCollection = new clsCustomerCollection();
        String Error = customerCollection.ThisCustomer.Valid(txtUsername.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNo.Text, txtEmail.Text, txtAddress.Text);
        if (Error == "")
        {
            customerCollection.ThisCustomer.Username = txtUsername.Text;
            customerCollection.ThisCustomer.CustomerFirstName = txtFirstName.Text;
            customerCollection.ThisCustomer.CustomerLastName = txtLastName.Text;
            customerCollection.ThisCustomer.CustomerTelephone = txtPhoneNo.Text;
            customerCollection.ThisCustomer.CustomerEmail = txtEmail.Text;
            customerCollection.ThisCustomer.CustomerAddress = txtAddress.Text;
            customerCollection.Add();
            Response.Redirect("CustomerPage.aspx");
        }
        else
        {
            lblError.Text = "There was a problem with teh data entered" + Error;
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;
        if (lstCustomer)
    }
}
