using System;
using System.Collections.Generic;
using System.Text;


public abstract class Driver
{
    protected Driver(string name,  Car car,double fuelConsumption)
    {
        this.Name = name;
        this.Car = car;
        this.FuelConsumptionPerKm = fuelConsumption;
        this.TotalTime = 0d;
    }
    public string Name { get; set; }
    public double TotalTime { get; private set; }
    public Car Car { get;} 
    public double FuelConsumptionPerKm { get; set; }
    public virtual double Speed => (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;

    public string FailureReason { get; private set; }
    public bool IsRacing { get;private set; }

    private string Status => IsRacing ? this.TotalTime.ToString() : this.FailureReason;
    public override string ToString()
    {
        return $"{this.Name} {this.Status}";
    }
}
