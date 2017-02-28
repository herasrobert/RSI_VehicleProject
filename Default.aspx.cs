using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page{


    List<Vehicle> vehicleList;
    protected void Page_Load(object sender, EventArgs e) {
        if ((List<Vehicle>)Session["data"] == null) { // Is new Session
            vehicleList = new List<Vehicle>();
            this.Session["data"] = vehicleList;
        } else { // Old Session
            vehicleList = (List<Vehicle>)Session["data"];
        }

        VehicleGridView.DataSource = (List<Vehicle>)Session["data"]; // Set GridView DataSource
        VehicleGridView.DataBind(); // Bind/Update GridView

    }

    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e) {
        if (DropDownList1.SelectedIndex == 0) { // None
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;

            MakeTxtBox.Visible = false;
            ModelTxtBox.Visible = false;
            ColorTxtBox.Visible = false;
            InteriorRadioBtn.Visible = false;
            NumDoorsTxtBox.Visible = false;
        }
        else if (DropDownList1.SelectedIndex == 1) { //Car
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true;

            MakeTxtBox.Visible = true;
            ModelTxtBox.Visible = true;
            ColorTxtBox.Visible = true;
            InteriorRadioBtn.Visible = true;
            NumDoorsTxtBox.Visible = true;

            AddBtn.Visible = true;
        } else if (DropDownList1.SelectedIndex == 2) { // Motorcycle
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = false;
            Label5.Visible = false;

            MakeTxtBox.Visible = true;
            ModelTxtBox.Visible = true;
            ColorTxtBox.Visible = true;
            InteriorRadioBtn.Visible = false;
            NumDoorsTxtBox.Visible = false;

            AddBtn.Visible = true;
        }
    }

    protected void AddBtn_Click(object sender, EventArgs e) {
        //The page will submit the form data to the server, which will create a new Car or Motorcycle object and store the new object in a data structure of type: List<Vehicle>.

        if (DropDownList1.SelectedIndex == 1) {
            vehicleList.Add(new Car(MakeTxtBox.Text, ModelTxtBox.Text, ColorTxtBox.Text, InteriorRadioBtn.Text, int.Parse(NumDoorsTxtBox.Text)));
        } else if (DropDownList1.SelectedIndex == 2) {
            vehicleList.Add(new Motorcycle(MakeTxtBox.Text, ModelTxtBox.Text, ColorTxtBox.Text));         
        }
                                                                     
        VehicleGridView.DataBind();
    }


    protected void MakeTxtBox_TextChanged(object sender, EventArgs e)
    {

    }


    protected void VehicleGridView_SelectedIndexChanged(object sender, EventArgs e) {        
    }

    protected void InteriorRadioBtn_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write(InteriorRadioBtn.Text);
    }
}