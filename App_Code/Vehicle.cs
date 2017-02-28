using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Vehicle
/// </summary>
/// 
public abstract class Vehicle {
    public Guid ID { get; set; }
    protected int Fuel { get; set; }
    protected bool IsEngineRunning { get; set; }
    public string make { get; set; }
    public string model { get; set; }
    public string color { get; set; }
    protected int numberOfWheels { get; set; }

    public Vehicle() {
        ID = Guid.NewGuid(); // this creates a Unique identifier
        Fuel = 0; // all vehicles start with no fuel
        IsEngineRunning = false; // all vehicles start with the engine off

        // add other initializers as needed
    }

    public abstract void StartEngine();
    public abstract void StopEngine();
    public abstract void FuelUp();
    public abstract void Accelerate();

    // add methods here
}
