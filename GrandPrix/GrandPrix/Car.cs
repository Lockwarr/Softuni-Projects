using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private const double maxFuel = 160;
        private double fuelAmount;
    public Car(int hp,double fuelAmount , Tyre tyre)
    {
        this.Hp = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
    }
    public int Hp { get; }
    public double FuelAmount
    {
        get { return this.FuelAmount; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Out of fuel");
            }
            this.FuelAmount = Math.Min(value, maxFuel);
        }
    }
    public Tyre Tyre { get; set; }
}
