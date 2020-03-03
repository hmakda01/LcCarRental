using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalClasses;




public partial class Car : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsCar AnCar = new clsCar();
        //capture the car name
        AnCar.CarName = txtCarName.Text;
        AnCar.CarModel = txtCarModel.Text;
        AnCar.CarColour = txtColour.Text;
        AnCar.EngineSize = txtEngineSize.Text;
        AnCar.RegPlate = txtCarReg.Text;
        AnCar.Price = Convert.ToInt32(txtPrice.Text); 
        //store car name i session object
        Session["AnCar"] = AnCar;
        //redirect to the viewr page
        Response.Redirect("CarViewr.aspx");
    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["CarID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AnCar.aspx");
    }

    //function for adding new records 
    void Add()
    {
        //create an instance of the cars
        clsCarCollection CarBook = new clsCarCollection();
        //validate the data on the web form
        String Error = CarBook.ThisCar.Valid(txtCarID.Text, txtCarName.Text, txtCarModel.Text, txtCarReg.Text, txtColour.Text, txtEngineSize.Text, txtPrice.Text);
        //if data is ok add to object
        if (Error == "")
        {
            //get the data entrted by user
            CarBook.ThisCar.RegPlate = txtCarReg.Text;
            CarBook.ThisCar.CarName = txtCarName.Text;
            CarBook.ThisCar.CarModel = txtCarModel.Text;
            CarBook.ThisCar.CarColour = txtColour.Text;
            CarBook.ThisCar.EngineSize = txtEngineSize.Text;
            CarBook.ThisCar.Price = Convert.ToInt32(txtPrice.Text);
            //add the records
            CarBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("Car.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the enterd data" + Error;
        }
    }
}