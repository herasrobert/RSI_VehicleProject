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
    protected int fuel { get; set; }
    protected bool isEngineRunning { get; set; }
    public string make { get; set; }
    public string model { get; set; }
    public string color { get; set; }
    protected int numberOfWheels { get; set; }

    public Vehicle(string makeRef, string modelRef, string colorRef) {
        ID = Guid.NewGuid(); // this creates a Unique identifier
        fuel = 0; // all vehicles start with no fuel
        isEngineRunning = false; // all vehicles start with the engine off

        this.make = makeRef;
        this.model = modelRef;
        this.color = colorRef;
        // add other initializers as needed
    }

    public abstract void StartEngine();
    public abstract void StopEngine();
    public abstract void FuelUp();
    public abstract void Accelerate();

    // add methods here
}
