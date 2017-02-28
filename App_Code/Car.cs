using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Car
/// </summary>
public class Car : Vehicle{
    string interior { get; set; }
    int numberOfDoors { get; set; }

    public Car(string makeRef, string modelRef, string colorRef, string interiorRef, int numberOfDoorsRef) {
        this.make = makeRef;
        this.model = modelRef;
        this.color = colorRef;
        this.numberOfWheels = 4;
        this.interior = interiorRef;
        this.numberOfDoors = numberOfDoorsRef;
        this.Fuel = 5;
        this.IsEngineRunning = false;
    }

    public override void Accelerate() {
        subtractFuel(1);
    }

    public override void FuelUp() {
        setFuel(5);
    }

    public override void StartEngine() {
        setIsEngineRunning(true);
    }   

    public override void StopEngine() {
        setIsEngineRunning(false);
    }

    public int getFuel() {
        return this.Fuel;
    }

    private void setFuel(int value)
    {
        this.Fuel = value;
    }

    private void setIsEngineRunning(bool value)
    {
        this.IsEngineRunning = value;
    }


    public bool getIsEngineRunning() {
        return this.IsEngineRunning;
    }

    public string getInterior() {
        return this.interior;
    }

    public int getNumberOfDoors()
    {
        return this.numberOfDoors;
    }

    public void subtractFuel(int value)
    {
        this.Fuel -= value;
    }


}