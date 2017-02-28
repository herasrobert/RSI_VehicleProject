using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Car : Vehicle{
    string interior { get; set; }
    int numberOfDoors { get; set; }

    public Car(string makeRef, string modelRef, string colorRef, string interiorRef, int numberOfDoorsRef) : base(makeRef, modelRef, colorRef) {       
        NumberOfWheels = 4;
        Interior = interiorRef;
        NumberOfDoors = numberOfDoorsRef;
        Fuel = 5;
        IsEngineRunning = false;
    }
    
    public override void Accelerate() {
        Fuel = Fuel - 1;
    }

    public override void FuelUp() {
        Fuel = 5;
    }

    public override void StartEngine() {
        IsEngineRunning = true;
    }   

    public override void StopEngine() {
        IsEngineRunning = false;
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

    public string Interior
    {
        get
        {
            return interior;
        }
        set
        {
            interior = value;
        }
    }

    public int NumberOfDoors
    {
        get
        {
            return numberOfDoors;
        }
        set
        {
            numberOfDoors = value;
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