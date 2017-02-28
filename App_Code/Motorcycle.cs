using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Motorcycle
/// </summary>
public class Motorcycle : Vehicle {
    bool KickStandExtended = true;


    public Motorcycle(string makeRef, string modelRef, string colorRef) {
        this.make = makeRef;
        this.model = modelRef;
        this.color = colorRef;
        this.numberOfWheels = 2;
        this.Fuel = 5;
        this.IsEngineRunning = false;
        RetractKickStand();
    }

    public override void Accelerate(){
        subtractFuel(2);
    }

    public override void FuelUp(){
        setFuel(5);
    }

    public override void StartEngine(){
        setIsEngineRunning(true);
    }

    public override void StopEngine(){
        setIsEngineRunning(false);
    }

    public void DeployKickStand() {
        KickStandExtended = false;
    }

    public void RetractKickStand() {
        KickStandExtended = true;
    }

    public int getFuel()
    {
        return this.Fuel;
    }

    private void setFuel(int value) {
        this.Fuel = value;
    }

    private void setIsEngineRunning(bool value) {
        this.IsEngineRunning = value;
    }

    public bool getIsEngineRunning()
    {
        return this.IsEngineRunning;
    }

    public bool getKickStandExtended()
    {
        return this.KickStandExtended;
    }

    public void subtractFuel(int value)
    {
        this.Fuel -= value;
    }

    public void switchKickStand() {
        if (getKickStandExtended() == true)
        {
            DeployKickStand();
        }
        else {
            RetractKickStand();
        }
    }
}

