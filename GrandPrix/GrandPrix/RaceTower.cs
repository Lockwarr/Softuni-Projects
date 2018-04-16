using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RaceTower
{
    private IList<Driver> drivers;
    private Stack<Driver> failedDrivers;
    private Track track;
    public RaceTower()
    {
        this.drivers = new List<Driver>();
    }

    public void SetTrackInfo(int lapsNumber, int trackLength)
    {
        this.track = new Track(lapsNumber, trackLength);
    }
    public void RegisterDriver(List<string> commandArgs)
    {
        try
        {
            string driverType = commandArgs[0];
            string driverName = commandArgs[1];

            int horsePower = int.Parse(commandArgs[2]);
            double fuelAmount = double.Parse(commandArgs[3]);

            string[] tyreArgs = commandArgs.Skip(4).ToArray();

            Tyre tyre = this.CreateTyre(tyreArgs);

            Car car = new Car(horsePower, fuelAmount, tyre);

            Driver driver = this.CreateDriver(driverType, driverName, car);
            this.drivers.Add(driver);
        }
        catch { }
    }
    private Driver CreateDriver(string type,string name,Car car)
    {
        Driver driver = null;
        if (type == "Aggressive")
        {
            driver = new AggressiveDriver(name, car);
            return driver;

        }else if(type == "Endurance")
        {
            driver = new EnduranceDriver(name, car);
            return driver;
        }
        throw new ArgumentException("Invalid Driver Type");
    }
    public Tyre CreateTyre(string[] tyreArgs)
    {
        string tyreTyre = tyreArgs[0];
        double tyreHardness = double.Parse(tyreArgs[1]);
        Tyre tyre = null;
        if(tyreTyre == "Hard")
        {
            tyre = new HardTyre(tyreHardness);
        }
        else if (tyreTyre=="Ultrasoft")
        {
            double grip = double.Parse(tyreArgs[2]);
            tyre = new UltrasoftTyre(tyreHardness, grip);
        }
        if(tyre == null)
        {
            throw new ArgumentException("Invalid Tyre Type");
        }
        return tyre;
    }

    public  void DriverBoxes(List<string> commandArgs)
    {
        //TODO: Add some logic here …
    }

    public string CompleteLaps(List<string> commandArgs)
    {
        //TODO: Add some logic here …
        throw new NotImplementedException();

    }

    public string GetLeaderboard()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"Lap {this.track.CurrentLap}/{this.track.LapsNumber}");

        IEnumerable<Driver> leaderboardDrivers = this.drivers
            .OrderBy(d => d.TotalTime)
            .Concat(this.failedDrivers);
        int position = 1;
        foreach(Driver driver in leaderboardDrivers)
        {
            builder.AppendLine($"{position} {driver.ToString()}");
            position++;
        }
        string result = builder.ToString().TrimEnd();
        return result;
    }

    public void ChangeWeather(List<string> commandArgs)
    {
        string weatherType = commandArgs[0];
        bool validWeather = Enum.TryParse(typeof(Weather), weatherType, out object weatherObj);
        if (!validWeather)
        {
            throw new ArgumentException("Invalid Weather Type");
        }
        Weather weather = (Weather)weatherObj;
        this.track.Weather = weather;
    }

}

