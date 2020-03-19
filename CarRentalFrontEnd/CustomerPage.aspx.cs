using CarRentalClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 
public partial class CustomerPage : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            DisplayCustomers();

            if (CustomerID != -1)
            {
                DisplayCustomers();
            }
        }
    }

     void DisplayCustomers()
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CustomerID);
        //
        txtUsername.Text = CustomerBook.ThisCustomer.Username;
        txtFirstName.Text = CustomerBook.ThisCustomer.CustomerFirstName;
        txtLastName.Text = CustomerBook.ThisCustomer.CustomerLastName;
        txtEmail.Text = CustomerBook.ThisCustomer.CustomerEmail;
        txtAddress.Text = CustomerBook.ThisCustomer.CustomerAddress;
        txtPhoneNo.Text = CustomerBook.ThisCustomer.CustomerTelephone;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (CustomerID == -1)
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
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = "There was a problem with the data entered" + Error;
        }
    }


    void Update()
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

            customerCollection.Update();
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = "There was a problem with the data entered" + Error;
        }
    }
}
