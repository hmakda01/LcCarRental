using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalClasses;
public partial class Delete : System.Web.UI.Page
{
    Int32 CarID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the car to be deleted from the session object 
        CarID = Convert.ToInt32(Session["CarID"]);
    }

    void DeleteCars()
    {
        //function to delete the selected record

        //create a new instance of the car book
        clsCarCollection CarBook = new clsCarCollection();
        //find the record to delete
        CarBook.ThisCar.Find(CarID);
        //delete record
        CarBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteCars();
        //redirect back to main page
        Response.Redirect("CarList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CarList.aspx");
    }
}