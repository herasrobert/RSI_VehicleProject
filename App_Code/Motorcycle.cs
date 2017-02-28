using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Motorcycle : Vehicle {
    bool KickStandExtended = true;


    public Motorcycle(string makeRef, string modelRef, string colorRef) : base(makeRef, modelRef, colorRef)
    {
        NumberOfWheels = 2;
        Fuel = 5;
        IsEngineRunning = false;
        RetractKickStand();
    }

    public override void Accelerate(){
        Fuel = Fuel - 2;
    }

    public override void FuelUp(){
        Fuel = 5;
    }

    public override void StartEngine(){
        IsEngineRunning = true;
    }

    public override void StopEngine(){
        IsEngineRunning = false;
    }

    public void DeployKickStand() {
        KickStandExtended = false;
    }

    public void RetractKickStand() {
        KickStandExtended = true;
    }
    
    public bool getKickStandExtended()
    {
        return this.KickStandExtended;
    }

    public int Fuel
    {
        get
        {
            return fuel;
        }
        set
        {
            fuel = value;
        }
    }

    public bool IsEngineRunning
    {
        get
        {
            return isEngineRunning;
        }
        set
        {
            isEngineRunning = value;
        }
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

    public int NumberOfWheels
    {
        get
        {
            return numberOfWheels;
        }
        set
        {
            numberOfWheels = value;
        }
    }
}

