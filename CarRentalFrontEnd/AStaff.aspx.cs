using CarRentalClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class AStaff : System.Web.UI.Page
{

    //vrabl to stre
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //gte the number of the staff to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if(IsPostBack == false)
        {
            //popute the list
            DisplayStaff();
            //if his is not a new record
            if (StaffId != -1)
            {
                //display the current da or the record
                DisplayStaff();
            }
        }
    }

   
    protected void btnOk_Click(object sender, EventArgs e)
    {
   
       {
            //adds a new rcord
            Add();
            Response.Redirect("StaffList.aspx");
       }
      
    }

    //function for adding records
    void Add()
    {
        //create an instance for staff
        clsStaffCollection StaffBook = new clsStaffCollection();
        //validate the data on the web form
        String Error = StaffBook.ThisStaff.Valid( txtStaffFirstName.Text, txtStaffLastName.Text, txtStaffEmail.Text, txtTelephone.Text, txtStaffDateOfBirth.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //get the data enetered by the user
            StaffBook.ThisStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
            StaffBook.ThisStaff.StaffFirstName = txtStaffFirstName.Text;
            StaffBook.ThisStaff.StaffLastName = txtStaffLastName.Text;
            StaffBook.ThisStaff.StaffEmail = txtStaffEmail.Text;
            StaffBook.ThisStaff.StaffTelephone = Convert.ToInt32(txtTelephone.Text);
            StaffBook.ThisStaff.StaffDateOfBirth = Convert.ToDateTime(txtStaffDateOfBirth.Text);
            //add the record
            StaffBook.Add();
            
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + Error;
        }

    }

    void Update()
    { 
     //create an instance for staff
        clsStaffCollection StaffBook = new clsStaffCollection();
    //validate the data on the web form
    String Error = StaffBook.ThisStaff.Valid( txtStaffFirstName.Text, txtStaffLastName.Text, txtStaffEmail.Text, txtTelephone.Text, txtStaffDateOfBirth.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //get the data enetered by the user
            StaffBook.ThisStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
            StaffBook.ThisStaff.StaffFirstName = txtStaffFirstName.Text;
            StaffBook.ThisStaff.StaffLastName = txtStaffLastName.Text;
            StaffBook.ThisStaff.StaffEmail = txtStaffEmail.Text;
            StaffBook.ThisStaff.StaffTelephone = Convert.ToInt32(txtTelephone.Text);
            StaffBook.ThisStaff.StaffDateOfBirth = Convert.ToDateTime(txtStaffDateOfBirth.Text);
            //add the record
            StaffBook.Update();
            //ll done rdirect back o page
            Response.Redirect("StaffList.aspx");
            
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + Error;
        }

    }

    void DisplayStaff()
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to update
        StaffBook.ThisStaff.Find(StaffId);
        //dispy  data
        txtStaffId.Text = StaffBook.ThisStaff.StaffId.ToString();
        txtStaffFirstName.Text = StaffBook.ThisStaff.StaffFirstName;
        txtStaffLastName.Text = StaffBook.ThisStaff.StaffLastName;
        txtStaffEmail.Text = StaffBook.ThisStaff.StaffEmail;
        txtTelephone.Text = StaffBook.ThisStaff.StaffTelephone.ToString();
        txtStaffDateOfBirth.Text = StaffBook.ThisStaff.StaffDateOfBirth.ToString();


    }



    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}