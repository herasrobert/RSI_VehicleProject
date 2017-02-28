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

        if (currentlySelectedVehicle != null) { 
            if (currentlySelectedVehicle is Car) {
                //Display Car Labels and stuff
                TypeLbl.Text = "Car";
                MakeLbl.Text = currentlySelectedCar.make;
                ModelLbl.Text = currentlySelectedCar.model;
                ColorLbl.Text = currentlySelectedCar.color;
                InteriorLbl.Visible = true;
                InteriorVarLbl.Visible = true;
                InteriorVarLbl.Text = currentlySelectedCar.getInterior();
                NumDoorsLbl.Visible = true;
                NumDoorsVarLbl.Visible = true;
                NumDoorsVarLbl.Text = ""+currentlySelectedCar.getNumberOfDoors();
                KickStandExtLbl.Visible = false;
                KickStandExtVarTxtBox.Visible = false;
                KickStandBtn.Visible = false;


                if (currentlySelectedCar.getIsEngineRunning() == true)
                {
                    EngStatusTxtBox.Text = "On";
                }
                else
                {
                    EngStatusTxtBox.Text = "Off";
                }

                FuelLevelTxtBox.Text = ""+currentlySelectedCar.getFuel();
            }
            else if (currentlySelectedVehicle is Motorcycle) {
                //Display Motorcycle Labels and stuff
                TypeLbl.Text = "Motorcycle";
                MakeLbl.Text = currentlySelectMotorcycle.make;
                ModelLbl.Text = currentlySelectMotorcycle.model;
                ColorLbl.Text = currentlySelectMotorcycle.color;
                KickStandExtLbl.Visible = true;
                KickStandExtVarTxtBox.Visible = true;
                KickStandExtVarTxtBox.Text = ""+currentlySelectMotorcycle.getKickStandExtended();
                KickStandBtn.Visible = true;


                if (currentlySelectMotorcycle.getIsEngineRunning() == true)
                {
                    EngStatusTxtBox.Text = "On";
                }
                else
                {
                    EngStatusTxtBox.Text = "Off";
                }

                FuelLevelTxtBox.Text = "" + currentlySelectMotorcycle.getFuel();
            }
        }


    }

    protected void StartEngBtn_Click(object sender, EventArgs e) {
        if (currentlySelectedVehicle != null){
            if (currentlySelectedVehicle is Car){
                
                if (currentlySelectedCar.getFuel() > 0 && currentlySelectedCar.getIsEngineRunning() == false) {
                    currentlySelectedCar.StartEngine();
                    currentlySelectedCar.subtractFuel(1);
                }
            }
            else if (currentlySelectedVehicle is Motorcycle) {
                if (currentlySelectMotorcycle.getKickStandExtended() == false && currentlySelectMotorcycle.getIsEngineRunning() == false) {
                    currentlySelectMotorcycle.StartEngine();
                } else {
                    errorLabel.Text = "Can't Start Engine.";
                }
            }
        }
    }

    protected void StopEngBtn_Click(object sender, EventArgs e) {
        if (currentlySelectedVehicle != null)
        {
            if (currentlySelectedVehicle is Car)
            {
               
                if (currentlySelectedCar.getIsEngineRunning())
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
                if (currentlySelectMotorcycle.getKickStandExtended() == true && currentlySelectMotorcycle.getIsEngineRunning() == true)
                {
                    currentlySelectMotorcycle.StopEngine();
                }
                else
                {
                    errorLabel.Text = "Can't Accelerate - Check Engine or Kick Stand";
                }
            }
        }
    }

    protected void FuelUpBtn_Click(object sender, EventArgs e) {
        if (currentlySelectedVehicle != null)
        {
            if (currentlySelectedVehicle is Car)
            {
                currentlySelectedCar.FuelUp();
            }
            else if (currentlySelectedVehicle is Motorcycle)
            {
                currentlySelectMotorcycle.FuelUp();
            }
        }
    }

    protected void AccelerateBtn_Click(object sender, EventArgs e) {
        if (currentlySelectedVehicle != null)
        {
            if (currentlySelectedVehicle is Car)
            {   
                if (currentlySelectedCar.getFuel() == 0)
                {
                    errorLabel.Text = "Not Enough Fuel - Stoping Engine";
                    currentlySelectedCar.StopEngine();
                }
                else if (currentlySelectedCar.getFuel() > 1 && currentlySelectedCar.getIsEngineRunning() == true)
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
                if (currentlySelectMotorcycle.getFuel() == 0)
                {
                    errorLabel.Text = "Not Enough Fuel - Stoping Engine";
                    currentlySelectMotorcycle.RetractKickStand();
                    currentlySelectMotorcycle.StopEngine();
                }
                else if (currentlySelectMotorcycle.getFuel() > 2 && currentlySelectMotorcycle.getIsEngineRunning() == true)
                {
                    currentlySelectMotorcycle.Accelerate();
                }
                else {
                    errorLabel.Text = "Can't Accelerate - Check Engine or KickStand";
                }
            }
        }
    }

    protected void KickStandBtn_Click(object sender, EventArgs e) {
        if (currentlySelectedVehicle != null)
        {
            if (currentlySelectedVehicle is Motorcycle)
            {
                currentlySelectMotorcycle.switchKickStand();
            }
        }
    }
}