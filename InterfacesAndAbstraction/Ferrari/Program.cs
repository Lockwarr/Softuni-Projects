using Ferrari.CarProps;
using System;


class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        Driver bestDriver = new Driver(name);
        Model niceModel = new Model();
        FerrariCar ferrari = new FerrariCar();
        Console.WriteLine($"{niceModel.model}/{ferrari.UseBrakes()}/{ferrari.PushGas()}/{bestDriver.Name}");
    }
}
