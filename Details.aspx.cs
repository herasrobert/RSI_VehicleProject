using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Details : System.Web.UI.Page {
    List<Vehicle> vehicleList;
    Vehicle currentlySelectedVehicle;
    Car currentlySelectedCar;
    Motorcycle currentlySelectMotorcycle;
    protected void Page_Load(object sender, EventArgs e) {
        if ((List<Vehicle>)Session["data"] != null) { // Not New Session
            vehicleList = (List<Vehicle>)Session["data"];
        }
        string queryId = Request.QueryString["Id"];
        string tempVehicleId = "";

        foreach (Vehicle vehicle in vehicleList) {
            tempVehicleId = "" + vehicle.ID;
            if (tempVehicleId == queryId) {
                if (vehicle is Car) {
                    currentlySelectedCar = vehicle as Car;
                } else if (vehicle is Motorcycle)
                {
                    currentlySelectMotorcycle = vehicle as Motorcycle;
                }
               currentlySelectedVehicle = vehicle;
            }
        }

        if (currentlySelectedVehicle == null)
        {
            //Redirect to Main Page
            Server.Transfer("Default.aspx", true);
        }
        else { 
            if (currentlySelectedVehicle is Car)
            {
                //Display Car Labels and stuff
                TypeLbl.Text = "Car";
                MakeLbl.Text = currentlySelectedCar.make;
                ModelLbl.Text = currentlySelectedCar.model;
                ColorLbl.Text = currentlySelectedCar.color;
                InteriorLbl.Visible = true;
                InteriorVarLbl.Visible = true;
                InteriorVarLbl.Text = currentlySelectedCar.Interior;
                NumDoorsLbl.Visible = true;
                NumDoorsVarLbl.Visible = true;
                NumDoorsVarLbl.Text = "" + currentlySelectedCar.NumberOfDoors;
                KickStandExtLbl.Visible = false;
                KickStandExtVarTxtBox.Visible = false;
                KickStandBtn.Visible = false;


                if (currentlySelectedCar.IsEngineRunning == true)
                {
                    EngStatusTxtBox.Text = "On";
                }
                else
                {
                    EngStatusTxtBox.Text = "Off";
                }

                FuelLevelTxtBox.Text = "" + currentlySelectedCar.Fuel;
            }
            else if (currentlySelectedVehicle is Motorcycle)
            {
                //Display Motorcycle Labels and stuff
                TypeLbl.Text = "Motorcycle";
                MakeLbl.Text = currentlySelectMotorcycle.make;
                ModelLbl.Text = currentlySelectMotorcycle.model;
                ColorLbl.Text = currentlySelectMotorcycle.color;
                KickStandExtLbl.Visible = true;
                KickStandExtVarTxtBox.Visible = true;
                KickStandExtVarTxtBox.Text = "" + currentlySelectMotorcycle.getKickStandExtended();
                KickStandBtn.Visible = true;


                if (currentlySelectMotorcycle.IsEngineRunning == true)
                {
                    EngStatusTxtBox.Text = "On";
                }
                else
                {
                    EngStatusTxtBox.Text = "Off";
                }

                FuelLevelTxtBox.Text = "" + currentlySelectMotorcycle.Fuel;
            }
        }


    }

    protected void StartEngBtn_Click(object sender, EventArgs e) {        
        if (currentlySelectedVehicle is Car){
                
            if (currentlySelectedCar.Fuel > 0 && currentlySelectedCar.IsEngineRunning == false) {
                currentlySelectedCar.StartEngine();
                currentlySelectedCar.Fuel = currentlySelectedCar.Fuel - 1;
            }
        }
        else if (currentlySelectedVehicle is Motorcycle) {
            if (currentlySelectMotorcycle.getKickStandExtended() == false && currentlySelectMotorcycle.IsEngineRunning == false) {
                currentlySelectMotorcycle.StartEngine();
            } else {
                errorLabel.Text = "Can't Start Engine.";
            }
        }        
    }

    protected void StopEngBtn_Click(object sender, EventArgs e) {        
        if (currentlySelectedVehicle is Car)
        {
               
            if (currentlySelectedCar.IsEngineRunning)
            {
                currentlySelectedCar.StopEngine();
            }
            else
            {
                errorLabel.Text = "Can't Accelerate - Check Engine is actually On";
            }
        }
        else if (currentlySelectedVehicle is Motorcycle)
        {                
            if (currentlySelectMotorcycle.getKickStandExtended() == true && currentlySelectMotorcycle.IsEngineRunning == true)
            {
                currentlySelectMotorcycle.StopEngine();
            }
            else
            {
                errorLabel.Text = "Can't Accelerate - Check Engine or Kick Stand";
            }
        }        
    }

    protected void FuelUpBtn_Click(object sender, EventArgs e) {        
        if (currentlySelectedVehicle is Car)
        {
            currentlySelectedCar.FuelUp();
        }
        else if (currentlySelectedVehicle is Motorcycle)
        {
            currentlySelectMotorcycle.FuelUp();
        }        
    }

    protected void AccelerateBtn_Click(object sender, EventArgs e) {        
        if (currentlySelectedVehicle is Car)
        {   
            if (currentlySelectedCar.Fuel == 0)
            {
                errorLabel.Text = "Not Enough Fuel - Stoping Engine";
                currentlySelectedCar.StopEngine();
            }
            else if (currentlySelectedCar.Fuel > 1 && currentlySelectedCar.IsEngineRunning == true)
            {
                currentlySelectedCar.Accelerate();
            }
            else
            {
                errorLabel.Text = "Can't Accelerate - Check Engine";
            }
        }
        else if (currentlySelectedVehicle is Motorcycle)
        {
            if (currentlySelectMotorcycle.Fuel == 0)
            {
                errorLabel.Text = "Not Enough Fuel - Stoping Engine";
                currentlySelectMotorcycle.RetractKickStand();
                currentlySelectMotorcycle.StopEngine();
            }
            else if (currentlySelectMotorcycle.Fuel > 2 && currentlySelectMotorcycle.IsEngineRunning == true)
            {
                currentlySelectMotorcycle.Accelerate();
            }
            else {
                errorLabel.Text = "Can't Accelerate - Check Engine or KickStand";
            }
        }        
    }

    protected void KickStandBtn_Click(object sender, EventArgs e) {        
        if (currentlySelectedVehicle is Motorcycle)
        {
            currentlySelectMotorcycle.switchKickStand();
        }       
    }
}