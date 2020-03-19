using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalClasses;

public partial class Car : System.Web.UI.Page
{
    Int32 CarID;

    protected void Page_Load(object sender, EventArgs e)
    {
        CarID = Convert.ToInt32(Session["CarID"]);
        if (IsPostBack == false)
        {
            DisplayCars();
            if (CarID != -1)
            {
                DisplayCars();
            }
        
        
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CarList.aspx");
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
       
      
        Response.Redirect("CarList.aspx");
    }

    //function for adding new records 
    void Add()
    {
        //create an instance of the cars
        clsCarCollection CarBook = new clsCarCollection();
        //validate the data on the web form
        String Error = CarBook.ThisCar.Valid(txtCarName.Text, txtCarModel.Text, txtCarReg.Text, txtColour.Text, txtEngineSize.Text, txtPrice.Text);
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
            lblError.Text = "Success";
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the enterd data" + Error;
        }

    }

    void Update()
    {
        //create an instance of the cars
        clsCarCollection CarBook = new clsCarCollection();
        //validate the data on the web form
        String Error = CarBook.ThisCar.Valid(txtCarName.Text, txtCarModel.Text, txtCarReg.Text, txtColour.Text, txtEngineSize.Text, txtPrice.Text);
        //if data is ok add to object
        if (Error == "")
        {
            CarBook.ThisCar.Find(CarID);
            //get the data entrted by user
            CarBook.ThisCar.RegPlate = txtCarReg.Text;
            CarBook.ThisCar.CarName = txtCarName.Text;
            CarBook.ThisCar.CarModel = txtCarModel.Text;
            CarBook.ThisCar.CarColour = txtColour.Text;
            CarBook.ThisCar.EngineSize = txtEngineSize.Text;
            CarBook.ThisCar.Price = Convert.ToInt32(txtPrice.Text);
            //add the records
            CarBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("CarList.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the enterd data" + Error;
        }
    }

    void DisplayCars()
    {
        //CECK IF IN THE CORECT SPOT
        //create an instance of the car book
        clsCarCollection Carbook = new clsCarCollection();
        //find the record to update
        Carbook.ThisCar.Find(CarID);
        //display the data for this record
        txtCarReg.Text = Carbook.ThisCar.RegPlate;
        txtCarName.Text = Carbook.ThisCar.CarName;
        txtCarModel.Text = Carbook.ThisCar.CarModel;
        txtColour.Text = Carbook.ThisCar.CarColour;
        txtEngineSize.Text = Carbook.ThisCar.EngineSize;
        txtPrice.Text = Carbook.ThisCar.Price.ToString();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        Add();
    }
}